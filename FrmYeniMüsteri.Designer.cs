namespace Renkli_Rüyalar_Pansiyonu
{
    partial class FrmYeniMüsteri
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

        #region Windows Form Designer generated co
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odalargroupbox = new System.Windows.Forms.GroupBox();
            this.BtnOda109 = new System.Windows.Forms.Button();
            this.BtnOda108 = new System.Windows.Forms.Button();
            this.BtnOda107 = new System.Windows.Forms.Button();
            this.BtnOda106 = new System.Windows.Forms.Button();
            this.BtnOda105 = new System.Windows.Forms.Button();
            this.BtnOda104 = new System.Windows.Forms.Button();
            this.BtnOda103 = new System.Windows.Forms.Button();
            this.BtnOda102 = new System.Windows.Forms.Button();
            this.BtnOda101 = new System.Windows.Forms.Button();
            this.BtnBosOda = new System.Windows.Forms.Button();
            this.BtnDoluOda = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.odalargroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.TxtKimlikNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgiler";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(386, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 23);
            this.label11.TabIndex = 40;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "ERKEK",
            "KADIN"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(147, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(60, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Cinsiyet:";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCikisTarihi.Location = new System.Drawing.Point(147, 464);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 31);
            this.DtpCikisTarihi.TabIndex = 37;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.CustomFormat = "";
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpGirisTarihi.Location = new System.Drawing.Point(147, 413);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 31);
            this.DtpGirisTarihi.TabIndex = 36;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(147, 370);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(164, 31);
            this.TxtUcret.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(79, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ücret:";
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNo.Location = new System.Drawing.Point(147, 325);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(164, 31);
            this.TxtOdaNo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Oda Numarası:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Violet;
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(147, 522);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(124, 37);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MskTxtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(147, 191);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(164, 31);
            this.MskTxtTelefon.TabIndex = 4;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKimlikNo.Location = new System.Drawing.Point(147, 279);
            this.TxtKimlikNo.MaxLength = 11;
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(164, 31);
            this.TxtKimlikNo.TabIndex = 6;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(147, 234);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(164, 31);
            this.TxtMail.TabIndex = 5;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Location = new System.Drawing.Point(147, 93);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(164, 31);
            this.TxtSoyadi.TabIndex = 2;
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(147, 45);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(164, 31);
            this.TxtAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adı:";
            // 
            // odalargroupbox
            // 
            this.odalargroupbox.Controls.Add(this.BtnOda109);
            this.odalargroupbox.Controls.Add(this.BtnOda108);
            this.odalargroupbox.Controls.Add(this.BtnOda107);
            this.odalargroupbox.Controls.Add(this.BtnOda106);
            this.odalargroupbox.Controls.Add(this.BtnOda105);
            this.odalargroupbox.Controls.Add(this.BtnOda104);
            this.odalargroupbox.Controls.Add(this.BtnOda103);
            this.odalargroupbox.Controls.Add(this.BtnOda102);
            this.odalargroupbox.Controls.Add(this.BtnOda101);
            this.odalargroupbox.Location = new System.Drawing.Point(581, 29);
            this.odalargroupbox.Name = "odalargroupbox";
            this.odalargroupbox.Size = new System.Drawing.Size(454, 404);
            this.odalargroupbox.TabIndex = 1;
            this.odalargroupbox.TabStop = false;
            this.odalargroupbox.Text = "Odalar";
            // 
            // BtnOda109
            // 
            this.BtnOda109.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda109.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda109.ForeColor = System.Drawing.Color.White;
            this.BtnOda109.Location = new System.Drawing.Point(310, 287);
            this.BtnOda109.Name = "BtnOda109";
            this.BtnOda109.Size = new System.Drawing.Size(75, 44);
            this.BtnOda109.TabIndex = 8;
            this.BtnOda109.Tag = "109";
            this.BtnOda109.Text = "109";
            this.BtnOda109.UseVisualStyleBackColor = false;
            this.BtnOda109.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda108
            // 
            this.BtnOda108.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda108.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda108.ForeColor = System.Drawing.Color.White;
            this.BtnOda108.Location = new System.Drawing.Point(192, 287);
            this.BtnOda108.Name = "BtnOda108";
            this.BtnOda108.Size = new System.Drawing.Size(75, 44);
            this.BtnOda108.TabIndex = 7;
            this.BtnOda108.Tag = "108";
            this.BtnOda108.Text = "108";
            this.BtnOda108.UseVisualStyleBackColor = false;
            this.BtnOda108.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda107
            // 
            this.BtnOda107.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda107.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda107.ForeColor = System.Drawing.Color.White;
            this.BtnOda107.Location = new System.Drawing.Point(70, 287);
            this.BtnOda107.Name = "BtnOda107";
            this.BtnOda107.Size = new System.Drawing.Size(75, 44);
            this.BtnOda107.TabIndex = 6;
            this.BtnOda107.Tag = "107";
            this.BtnOda107.Text = "107";
            this.BtnOda107.UseVisualStyleBackColor = false;
            this.BtnOda107.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda106
            // 
            this.BtnOda106.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda106.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda106.ForeColor = System.Drawing.Color.White;
            this.BtnOda106.Location = new System.Drawing.Point(310, 190);
            this.BtnOda106.Name = "BtnOda106";
            this.BtnOda106.Size = new System.Drawing.Size(75, 44);
            this.BtnOda106.TabIndex = 5;
            this.BtnOda106.Tag = "106";
            this.BtnOda106.Text = "106";
            this.BtnOda106.UseVisualStyleBackColor = false;
            this.BtnOda106.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda105
            // 
            this.BtnOda105.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda105.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda105.ForeColor = System.Drawing.Color.White;
            this.BtnOda105.Location = new System.Drawing.Point(192, 190);
            this.BtnOda105.Name = "BtnOda105";
            this.BtnOda105.Size = new System.Drawing.Size(75, 44);
            this.BtnOda105.TabIndex = 4;
            this.BtnOda105.Tag = "105";
            this.BtnOda105.Text = "105";
            this.BtnOda105.UseVisualStyleBackColor = false;
            this.BtnOda105.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda104
            // 
            this.BtnOda104.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda104.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda104.ForeColor = System.Drawing.Color.White;
            this.BtnOda104.Location = new System.Drawing.Point(70, 190);
            this.BtnOda104.Name = "BtnOda104";
            this.BtnOda104.Size = new System.Drawing.Size(75, 44);
            this.BtnOda104.TabIndex = 3;
            this.BtnOda104.Tag = "104";
            this.BtnOda104.Text = "104";
            this.BtnOda104.UseVisualStyleBackColor = false;
            this.BtnOda104.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda103
            // 
            this.BtnOda103.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda103.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda103.ForeColor = System.Drawing.Color.White;
            this.BtnOda103.Location = new System.Drawing.Point(310, 86);
            this.BtnOda103.Name = "BtnOda103";
            this.BtnOda103.Size = new System.Drawing.Size(75, 44);
            this.BtnOda103.TabIndex = 2;
            this.BtnOda103.Tag = "103";
            this.BtnOda103.Text = "103";
            this.BtnOda103.UseVisualStyleBackColor = false;
            this.BtnOda103.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda102
            // 
            this.BtnOda102.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda102.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda102.ForeColor = System.Drawing.Color.White;
            this.BtnOda102.Location = new System.Drawing.Point(192, 86);
            this.BtnOda102.Name = "BtnOda102";
            this.BtnOda102.Size = new System.Drawing.Size(75, 44);
            this.BtnOda102.TabIndex = 1;
            this.BtnOda102.Tag = "102";
            this.BtnOda102.Text = "102";
            this.BtnOda102.UseVisualStyleBackColor = false;
            this.BtnOda102.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda101
            // 
            this.BtnOda101.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnOda101.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda101.ForeColor = System.Drawing.Color.White;
            this.BtnOda101.Location = new System.Drawing.Point(70, 86);
            this.BtnOda101.Name = "BtnOda101";
            this.BtnOda101.Size = new System.Drawing.Size(75, 44);
            this.BtnOda101.TabIndex = 0;
            this.BtnOda101.Tag = "101";
            this.BtnOda101.Text = "101";
            this.BtnOda101.UseVisualStyleBackColor = false;
            this.BtnOda101.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnBosOda
            // 
            this.BtnBosOda.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnBosOda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBosOda.ForeColor = System.Drawing.Color.White;
            this.BtnBosOda.Location = new System.Drawing.Point(878, 477);
            this.BtnBosOda.Name = "BtnBosOda";
            this.BtnBosOda.Size = new System.Drawing.Size(75, 44);
            this.BtnBosOda.TabIndex = 9;
            this.BtnBosOda.Text = "BOŞ";
            this.BtnBosOda.UseVisualStyleBackColor = false;
            this.BtnBosOda.Click += new System.EventHandler(this.BtnBosOda_Click);
            // 
            // BtnDoluOda
            // 
            this.BtnDoluOda.BackColor = System.Drawing.Color.Red;
            this.BtnDoluOda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoluOda.ForeColor = System.Drawing.Color.White;
            this.BtnDoluOda.Location = new System.Drawing.Point(878, 544);
            this.BtnDoluOda.Name = "BtnDoluOda";
            this.BtnDoluOda.Size = new System.Drawing.Size(75, 44);
            this.BtnDoluOda.TabIndex = 10;
            this.BtnDoluOda.Text = "DOLU";
            this.BtnDoluOda.UseVisualStyleBackColor = false;
            this.BtnDoluOda.Click += new System.EventHandler(this.BtnDoluOda_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 636);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Made With";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Game_hearts;
            this.pictureBox1.Location = new System.Drawing.Point(99, 629);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmYeniMüsteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnDoluOda);
            this.Controls.Add(this.odalargroupbox);
            this.Controls.Add(this.BtnBosOda);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FrmYeniMüsteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FrmYeniMüsteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.odalargroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox odalargroupbox;
        private System.Windows.Forms.Button BtnDoluOda;
        private System.Windows.Forms.Button BtnBosOda;
        private System.Windows.Forms.Button BtnOda109;
        private System.Windows.Forms.Button BtnOda108;
        private System.Windows.Forms.Button BtnOda107;
        private System.Windows.Forms.Button BtnOda106;
        private System.Windows.Forms.Button BtnOda105;
        private System.Windows.Forms.Button BtnOda104;
        private System.Windows.Forms.Button BtnOda103;
        private System.Windows.Forms.Button BtnOda102;
        private System.Windows.Forms.Button BtnOda101;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}