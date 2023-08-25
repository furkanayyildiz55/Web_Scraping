using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HtmlAgilityPack;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace WebScrapping
{
    public partial class Form1 : Form
    {
        List<Veri> VeriList = new List<Veri>();
        BindingSource bindingSource = new BindingSource();

        string KlasörYolu = "";
        string[] HTMLDosyaları;

        //DGV
        int rowIndexFromMouseDown;
        DataGridViewRow rw;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //HtmlAgilityPack.HtmlDocument html = LoadHTML(@"C:\Users\furka\Desktop\HTML\(MRT04).html");
            //VeriCek(html);

            //dataGridView1.DataSource = VeriList;
        }

        private HtmlAgilityPack.HtmlDocument LoadHTML(string url)
        {
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            // There are various options, set as needed
            htmlDoc.OptionFixNestedTags = true;
            // filePath is a path to a file containing the html
            htmlDoc.Load(url);
            return htmlDoc;
        }

        private Veri VeriCek(HtmlAgilityPack.HtmlDocument HtmlDocument , string FolderName)
        {
            Veri veri = new Veri();

            ////kodu    pc kodu
            HtmlNode table = HtmlDocument.DocumentNode.SelectSingleNode("//table[@class='reportHeader']");
            veri.Kodu = table.SelectNodes(".//td")[0].InnerText;

            ////kullanıcı
            //veri.Kullanıcı = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[9]/div/table/tbody/tr[9]/td[2]")[0].InnerText;

            //İşletim Sistemi
            veri.İşletimSistemi = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[3]/div")[0].InnerText;
            veri.İşletimSistemi = StringAyır(veri.İşletimSistemi, "Install");
            veri.İşletimSistemi = ReplaceAndTrim(veri.İşletimSistemi);
            
            //Ana Kart
            veri.AnakartModeli = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[6]/div")[0].InnerText;
            veri.AnakartModeli = StringAyır(veri.AnakartModeli, "Bus");
            veri.AnakartModeli = ReplaceAndTrim(veri.AnakartModeli);

            //Disk Kapasitesi
            veri.DiskKapasitesi = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[7]/div")[0].InnerText;
            //veri.DiskKapasitesi = StringAyır(veri.DiskKapasitesi, "Bus");
            veri.DiskKapasitesi = ReplaceAndTrim(veri.DiskKapasitesi);

            //İşlemci
            veri.İşlemci = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[5]/div")[0].InnerText;
            veri.İşlemci = StringAyır(veri.İşlemci, "cache");
            veri.İşlemci = ReplaceAndTrim(veri.İşlemci);

            //Ram
            veri.RamKapasitesi = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[8]/div[1]")[0].InnerText;
            veri.RamKapasitesi = StringAyır(veri.RamKapasitesi, "Usable");
            veri.RamKapasitesi = ReplaceAndTrim(veri.RamKapasitesi);

            //Modeli
            string SistemModel = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[4]/div")[0].InnerText;
            SistemModel = ReplaceAndTrim(SistemModel);

            if (SistemModel.Contains("System Service Tag:"))
            {
                veri.Modeli = StringAyır(SistemModel, "System Service Tag:");
            }

            else if (SistemModel.Contains("System Serial Number: "))
            {
                veri.Modeli = StringAyır(SistemModel, "System Serial Number: ");
            }
            else
            {
                veri.Modeli = "Tanımlanamayan Model";
            }

            //Bilgisayar Türü
            HtmlNodeCollection veriListesi = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[4]/div");
            veri.BilgisayarTürü = veriListesi[0].InnerText.Substring(veriListesi[0].InnerText.LastIndexOf("Enclosure Type: ") + 16);


            //ip
            HtmlNodeCollection spanNodes = HtmlDocument.DocumentNode.SelectNodes("//span[contains(text(), 'primary')]");
            List<HtmlNode> tdNodes = new List<HtmlNode>();
            HtmlNode trNode = null;

            if ( veri.BilgisayarTürü.Contains("Tower"))
            {

            }
            else if (veri.BilgisayarTürü.Contains("Desktop") || veri.BilgisayarTürü.Contains("Laptop") || veri.BilgisayarTürü.Contains("Notebook"))
            {
                foreach (HtmlNode spanNode in spanNodes)
                {
                    HtmlNode tdNode = spanNode.ParentNode;
                    trNode = tdNode.ParentNode;
                    var ip = trNode.SelectNodes("td")[2].InnerText;
                    veri.İpAdresi = ip;
                }
            }
            else
            {
                veri.BilgisayarTürü = "Tanımlanamayan Tür";
            }


            //mac 
            foreach (HtmlNode spanNode in spanNodes)
            {
                HtmlNode tdNode = spanNode.ParentNode;
                trNode = tdNode.ParentNode;
            }
            HtmlNode newNode=trNode;
            for (int i = 0; i < 6; i++)
            {
                newNode = newNode.NextSibling;
            }
            veri.MacAdresi = newNode.InnerText;
            veri.MacAdresi = GetNext(veri.MacAdresi, "Address:");

            //Ekran Kartı
            string EkranMonitor = HtmlDocument.DocumentNode.SelectNodes(@"//*[@id=""pageBody""]/div[3]/div[12]/div")[0].InnerText;
            string[] EkranKartıListesi = EkranMonitor.Split(new string[] { "[Display adapter]" }, StringSplitOptions.None);
            veri.EkranKartı = "";
            for (int i = 0; i < EkranKartıListesi.Length-1; i++)
            {
                EkranKartıListesi[i] = ReplaceAndTrim(EkranKartıListesi[i]);
                veri.EkranKartı  +=  (i+1).ToString()+"-" + EkranKartıListesi[i] + " ";
            }

            //Monitör
            string Monitör = EkranKartıListesi[EkranKartıListesi.Length - 1];
            string[] MonitörListesi = Monitör.Split(new string[] { "[Monitor]" }, StringSplitOptions.None);
            veri.Monitör = "";

            for (int i = 0; i < MonitörListesi.Length-1; i++)
            {
                MonitörListesi[i] = ReplaceAndTrim(MonitörListesi[i]);
                //MonitörListesi[i] = Between(MonitörListesi[i], "(", ")");
                veri.Monitör += (i + 1).ToString() + "-" + MonitörListesi[i] + " ";
            }

            //Kullanıcı Adı Soyadı
            if (rd_isim.Checked == true) 
            {
                if (FolderName.Contains("-"))
                {
                    veri.KullanıcıAdıSoyadı = StringAyır(FolderName, "-");
                }
                else if (FolderName.Contains("_"))
                {
                    veri.KullanıcıAdıSoyadı = StringAyır(FolderName, "_");
                }
                else
                {
                    veri.KullanıcıAdıSoyadı = "Kullanıcı Adı Ayrıştırılamadı";
                }
            }

            if (rd1_pckodu.Checked == true)
            {
                if (FolderName.Contains("-"))
                {
                    veri.KullanıcıAdıSoyadı = GetNext(FolderName, "-");
                }
                else if (FolderName.Contains("_"))
                {
                    veri.KullanıcıAdıSoyadı = GetNext(FolderName, "_");
                }
                else
                {
                    veri.KullanıcıAdıSoyadı = "Kullanıcı Adı Ayrıştırılamadı";
                }
            }
            veri.Kullanıcı = "---";
            return veri;
        }





        #region Srting İşlemleri 

        public string GetNext(string orjStr , string prevStr)
        {
            if (orjStr.Contains(prevStr))
            {
                int index = orjStr.IndexOf(prevStr);
                return orjStr.Substring( index + prevStr.Length);
            }
            else
            {
                return "Aranan Değer Bulunamadı!";
            }
        }

        public string ReplaceAndTrim(string orjStr)
        {
            return orjStr.Replace("\n", "").Replace("\t", "").Replace("\r", "").Trim();
        }

        public string Between(string Text, string FirstString, string LastString)

        {
            string STR = Text;
            string STRFirst = FirstString;
            string STRLast = LastString;
            string FinalString;

            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        public string StringAyır(string originalString , string searchTerm)
        {
            int index = originalString.IndexOf(searchTerm);

            if (index != -1)
            {
                string desiredSubstring = originalString.Substring(0, index );
                //Console.WriteLine("Aranan kısım: " + desiredSubstring);
                //label2.Text = desiredSubstring;

                // Geri kalanını silmek için:
                string remainingString = originalString.Substring(index + searchTerm.Length);
                return desiredSubstring;
            }
            else
            {
                return "Null-1";
            }
        }

        #endregion


        #region Form Olayları Click İşlemler

        private void klasor_yolu_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                lbl_status.Text = "";

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    KlasörYolu  = folderDialog.SelectedPath;
                    lbl_klasor_yolu.Text = folderDialog.SelectedPath;
                    klasor_label.Text = "Seçim Gerçekleşti";
                    lbl_status.Text = "Durum: Klasör Seçildi";
                    HTMLDosyaları = Directory.GetFiles(KlasörYolu);

                }
                else
                {
                    MessageBox.Show("Klasör seçilmedi veya işlem iptal edildi.", "Klasör Seçimi");
                    klasor_label.Text = "Kalsör Yolu Seçiniz !";
                }
            }
        }

        private void btn_Ayikla_Click(object sender, EventArgs e)
        {
            VeriList.Clear();
            bindingSource.DataSource= null;
            dataGridView1.Refresh();
            
            if(!string.IsNullOrWhiteSpace(KlasörYolu))
            {
                string[] klasorler = Directory.GetDirectories(KlasörYolu);
                for (int j = 0; j < klasorler.Length; j++)
                {
                    string hedefKlasör = klasorler[j] + "\\tmp";
                    string[] Dosyalar;
                    try
                    {
                        Dosyalar = Directory.GetFiles(hedefKlasör);
                        string HedefHtml = Dosyalar[0];
                        string FolderName = Path.GetFileName(Path.GetDirectoryName(hedefKlasör));
                        Veri ÇekilenVeri = new Veri();

                        ÇekilenVeri = VeriCek(LoadHTML(HedefHtml), FolderName);
                        VeriList.Add(ÇekilenVeri);

                    }
                    catch (DirectoryNotFoundException)
                    {
                        lbl_status.Text = "Lütfen Klasörü Seçiniz.";
                    }

                }

                bindingSource.DataSource = VeriList;
                dataGridView1.DataSource = bindingSource;
                lbl_status.Text = "Durum: Veriler Çekildi";
            }


        }

        private void btn_excel_aktarma_Click(object sender, EventArgs e)
        {
            int progressMax = (dataGridView1.ColumnCount) * (dataGridView1.RowCount);
            progress_excel.Maximum = progressMax;
            int progress = 0;

            try
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Bu işlem, uzun sürebilir. Devam etmek isyiyormusunuz...Aktarma bitene kadar Excel'de işlem yapmayınız !", "EXCEL'E AKTARMA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Excel.Application uyg = new Excel.Application();
                    uyg.Visible = true;
                    Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                    Excel.Worksheet sheet1 = (Excel.Worksheet)kitap.Sheets[1];
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        Excel.Range myRange = (Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.EntireRow.Font.Bold = true;
                        myRange.Interior.Color = Excel.XlRgbColor.rgbCadetBlue;
                        myRange.Value2 = dataGridView1.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            Excel.Range myRange = (Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = dataGridView1[i, j].Value;
                            myRange.VerticalAlignment = XlVAlign.xlVAlignTop;
                            progress += 1;
                            progress_excel.Value = progress;
                        }
                    }
                    lbl_status.Text = "Durum: Excel Aktarma Gerçekleşti";

                }
                else
                {
                    MessageBox.Show("İŞLEM İPTAL EDİLDİ.", "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
            catch (Exception)
            {
                MessageBox.Show("İŞLEM TAMAMLANMADAN EXCEL PENCERESİNİ KAPATTINIZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        #endregion


        #region Form Hareketleri
        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        int mouseX, mouseY;
        private void lbl_Upside_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X - this.Left;
            mouseY = MousePosition.Y - this.Top;

            timer1.Enabled = true;  
        }

        private void lbl_Upside_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - mouseX;
            this.Top = MousePosition.Y - mouseY;
        }

        #endregion


        #region Logo-İnfo Hareketleri

        private void pcb_logo_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.erybilisim.com/";
                Process.Start("chrome", url);
            }
            catch (Exception)
            {
                MessageBox.Show("https://www.erybilisim.com/");
            }
        }



        private void btn_info_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.furkanayyildiz.net";
                Process.Start("chrome", url);
            }
            catch (Exception)
            {
                MessageBox.Show("https://www.furkanayyildiz.net");
            }
        }

        #endregion


        #region DGV
        //çift tıkla ve tut istenilen satıra sürükle bırak
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    rw = dataGridView1.SelectedRows[0];
                    rowIndexFromMouseDown = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.DoDragDrop(rw, DragDropEffects.Move);
                }
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            int rowIndexOfItemUnderMouseToDrop;
            System.Drawing.Point clientPoint = dataGridView1.PointToClient(new System.Drawing.Point(e.X, e.Y));
            rowIndexOfItemUnderMouseToDrop = dataGridView1.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            //rowIndexFromMouseDown ilk tıklandığındaki index
            //rowIndexOfItemUnderMouseToDrop bırakıldığındaki index

            if (e.Effect == DragDropEffects.Move)
            {
                Veri temp = VeriList[rowIndexOfItemUnderMouseToDrop];
                VeriList[rowIndexOfItemUnderMouseToDrop] = VeriList[rowIndexFromMouseDown];
                VeriList[rowIndexFromMouseDown] = temp;
                bindingSource.DataSource = VeriList;


                //Veri temp = VeriList[rowIndexFromMouseDown];
                //VeriList.RemoveAt(rowIndexFromMouseDown-1);


                //VeriList.Insert(rowIndexOfItemUnderMouseToDrop, temp);

                //bindingSource.DataSource = VeriList;

            }
            

        }

        #endregion

    }
}
