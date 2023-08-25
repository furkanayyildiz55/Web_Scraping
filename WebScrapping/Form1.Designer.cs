namespace WebScrapping
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_excel_aktarma = new System.Windows.Forms.Button();
            this.klasor_yolu = new System.Windows.Forms.Button();
            this.klasor_label = new System.Windows.Forms.Label();
            this.btn_Ayikla = new System.Windows.Forms.Button();
            this.rd1_pckodu = new System.Windows.Forms.RadioButton();
            this.rd_isim = new System.Windows.Forms.RadioButton();
            this.lbl_Upside = new System.Windows.Forms.Label();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_klasor_yolu = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_status = new System.Windows.Forms.Label();
            this.progress_excel = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excel_aktarma
            // 
            this.btn_excel_aktarma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excel_aktarma.BackgroundImage")));
            this.btn_excel_aktarma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excel_aktarma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excel_aktarma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excel_aktarma.Location = new System.Drawing.Point(38, 371);
            this.btn_excel_aktarma.Name = "btn_excel_aktarma";
            this.btn_excel_aktarma.Size = new System.Drawing.Size(81, 62);
            this.btn_excel_aktarma.TabIndex = 5;
            this.btn_excel_aktarma.UseVisualStyleBackColor = true;
            this.btn_excel_aktarma.Click += new System.EventHandler(this.btn_excel_aktarma_Click);
            // 
            // klasor_yolu
            // 
            this.klasor_yolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.klasor_yolu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("klasor_yolu.BackgroundImage")));
            this.klasor_yolu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.klasor_yolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.klasor_yolu.FlatAppearance.BorderSize = 0;
            this.klasor_yolu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.klasor_yolu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.klasor_yolu.Location = new System.Drawing.Point(46, 156);
            this.klasor_yolu.Name = "klasor_yolu";
            this.klasor_yolu.Size = new System.Drawing.Size(73, 57);
            this.klasor_yolu.TabIndex = 7;
            this.klasor_yolu.UseVisualStyleBackColor = false;
            this.klasor_yolu.Click += new System.EventHandler(this.klasor_yolu_Click);
            // 
            // klasor_label
            // 
            this.klasor_label.AutoSize = true;
            this.klasor_label.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klasor_label.ForeColor = System.Drawing.Color.Transparent;
            this.klasor_label.Location = new System.Drawing.Point(10, 216);
            this.klasor_label.Name = "klasor_label";
            this.klasor_label.Size = new System.Drawing.Size(157, 26);
            this.klasor_label.TabIndex = 8;
            this.klasor_label.Text = "Lütfen Klasör Seçiniz";
            // 
            // btn_Ayikla
            // 
            this.btn_Ayikla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Ayikla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ayikla.BackgroundImage")));
            this.btn_Ayikla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ayikla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ayikla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayikla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Ayikla.Location = new System.Drawing.Point(27, 254);
            this.btn_Ayikla.Name = "btn_Ayikla";
            this.btn_Ayikla.Size = new System.Drawing.Size(107, 78);
            this.btn_Ayikla.TabIndex = 9;
            this.btn_Ayikla.UseVisualStyleBackColor = false;
            this.btn_Ayikla.Click += new System.EventHandler(this.btn_Ayikla_Click);
            // 
            // rd1_pckodu
            // 
            this.rd1_pckodu.AutoSize = true;
            this.rd1_pckodu.Checked = true;
            this.rd1_pckodu.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd1_pckodu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rd1_pckodu.Location = new System.Drawing.Point(27, 105);
            this.rd1_pckodu.Name = "rd1_pckodu";
            this.rd1_pckodu.Size = new System.Drawing.Size(115, 27);
            this.rd1_pckodu.TabIndex = 10;
            this.rd1_pckodu.TabStop = true;
            this.rd1_pckodu.Text = "Pc Kodu-İsim";
            this.rd1_pckodu.UseVisualStyleBackColor = true;
            // 
            // rd_isim
            // 
            this.rd_isim.AutoSize = true;
            this.rd_isim.BackColor = System.Drawing.Color.Transparent;
            this.rd_isim.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_isim.ForeColor = System.Drawing.Color.White;
            this.rd_isim.Location = new System.Drawing.Point(27, 78);
            this.rd_isim.Name = "rd_isim";
            this.rd_isim.Size = new System.Drawing.Size(115, 27);
            this.rd_isim.TabIndex = 11;
            this.rd_isim.Text = "İsim-Pc Kodu";
            this.rd_isim.UseVisualStyleBackColor = false;
            // 
            // lbl_Upside
            // 
            this.lbl_Upside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbl_Upside.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Upside.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Upside.Location = new System.Drawing.Point(0, 0);
            this.lbl_Upside.Name = "lbl_Upside";
            this.lbl_Upside.Size = new System.Drawing.Size(1099, 65);
            this.lbl_Upside.TabIndex = 12;
            this.lbl_Upside.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Upside_MouseDown);
            this.lbl_Upside.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_Upside_MouseUp);
            // 
            // pcb_logo
            // 
            this.pcb_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pcb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pcb_logo.Image")));
            this.pcb_logo.Location = new System.Drawing.Point(47, 8);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(79, 47);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_logo.TabIndex = 13;
            this.pcb_logo.TabStop = false;
            this.pcb_logo.Click += new System.EventHandler(this.pcb_logo_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1059, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(29, 39);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(1021, 7);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(29, 39);
            this.btn_minimize.TabIndex = 15;
            this.btn_minimize.Text = "____";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1099, 0);
            this.label3.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 361);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Verileri Çek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Excel Aktar";
            // 
            // lbl_klasor_yolu
            // 
            this.lbl_klasor_yolu.AutoSize = true;
            this.lbl_klasor_yolu.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_klasor_yolu.ForeColor = System.Drawing.Color.White;
            this.lbl_klasor_yolu.Location = new System.Drawing.Point(184, 70);
            this.lbl_klasor_yolu.Name = "lbl_klasor_yolu";
            this.lbl_klasor_yolu.Size = new System.Drawing.Size(0, 26);
            this.lbl_klasor_yolu.TabIndex = 19;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info.BackgroundImage")));
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_info.Location = new System.Drawing.Point(1056, 68);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(25, 25);
            this.btn_info.TabIndex = 20;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(746, 70);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 26);
            this.lbl_status.TabIndex = 21;
            // 
            // progress_excel
            // 
            this.progress_excel.ForeColor = System.Drawing.Color.IndianRed;
            this.progress_excel.Location = new System.Drawing.Point(12, 458);
            this.progress_excel.Name = "progress_excel";
            this.progress_excel.Size = new System.Drawing.Size(158, 10);
            this.progress_excel.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1099, 473);
            this.Controls.Add(this.progress_excel);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.lbl_klasor_yolu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pcb_logo);
            this.Controls.Add(this.lbl_Upside);
            this.Controls.Add(this.rd_isim);
            this.Controls.Add(this.rd1_pckodu);
            this.Controls.Add(this.btn_Ayikla);
            this.Controls.Add(this.klasor_label);
            this.Controls.Add(this.klasor_yolu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_excel_aktarma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_excel_aktarma;
        private System.Windows.Forms.Button klasor_yolu;
        private System.Windows.Forms.Label klasor_label;
        private System.Windows.Forms.Button btn_Ayikla;
        private System.Windows.Forms.RadioButton rd1_pckodu;
        private System.Windows.Forms.RadioButton rd_isim;
        private System.Windows.Forms.Label lbl_Upside;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_klasor_yolu;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progress_excel;
        private System.Windows.Forms.Label label2;
    }
}

