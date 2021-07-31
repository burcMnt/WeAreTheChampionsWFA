
namespace WeAreTheChampionsWFA
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMuzik = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboKarsilasmaSil = new System.Windows.Forms.PictureBox();
            this.pboKarsilasmaDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboKarsilasmaEkle = new System.Windows.Forms.PictureBox();
            this.lviKarsilasma = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTakimOyuncuSil = new System.Windows.Forms.Button();
            this.btnTakimOyuncuAta = new System.Windows.Forms.Button();
            this.lstTakimOyunculari = new System.Windows.Forms.ListBox();
            this.cboOyuncuAd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTakimAdO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTakimRenkSil = new System.Windows.Forms.Button();
            this.btnTakimRenkAta = new System.Windows.Forms.Button();
            this.lstTakiminRengi = new System.Windows.Forms.ListBox();
            this.cboRenkAd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTakimAd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTakimSil = new System.Windows.Forms.Button();
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.lstTakimAdlari = new System.Windows.Forms.ListBox();
            this.txtTakimAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRenkIptal = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pboSecilenRenk = new System.Windows.Forms.PictureBox();
            this.btnRenkDuzenle = new System.Windows.Forms.Button();
            this.btnRenkSil = new System.Windows.Forms.Button();
            this.btnRenkEkle = new System.Windows.Forms.Button();
            this.lstRenkler = new System.Windows.Forms.ListBox();
            this.pboRenkler = new System.Windows.Forms.PictureBox();
            this.txtRenkAd = new System.Windows.Forms.TextBox();
            this.mtbBDegeri = new System.Windows.Forms.MaskedTextBox();
            this.mtbGDegeri = new System.Windows.Forms.MaskedTextBox();
            this.mtbRDegeri = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOyuncuIptal = new System.Windows.Forms.Button();
            this.btnOyuncuDuzenle = new System.Windows.Forms.Button();
            this.btnOyuncuSil = new System.Windows.Forms.Button();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.lstOyuncular = new System.Windows.Forms.ListBox();
            this.txtOyuncuAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboKarsilasmaSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboKarsilasmaDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboKarsilasmaEkle)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboSecilenRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenkler)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-2, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(997, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Karşılaşmalar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(997, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renkler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.ForeColor = System.Drawing.Color.Blue;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(997, 573);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Oyuncular";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._3ab72746e777400983ad8371a2e6a4e6;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.chbMuzik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pboKarsilasmaSil);
            this.groupBox1.Controls.Add(this.pboKarsilasmaDuzenle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pboKarsilasmaEkle);
            this.groupBox1.Controls.Add(this.lviKarsilasma);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1005, 573);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karşılaşma";
            // 
            // chbMuzik
            // 
            this.chbMuzik.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbMuzik.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chbMuzik.Checked = true;
            this.chbMuzik.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMuzik.Location = new System.Drawing.Point(4, 0);
            this.chbMuzik.Name = "chbMuzik";
            this.chbMuzik.Size = new System.Drawing.Size(112, 40);
            this.chbMuzik.TabIndex = 7;
            this.chbMuzik.Text = "Sound Off";
            this.chbMuzik.UseVisualStyleBackColor = false;
            this.chbMuzik.CheckedChanged += new System.EventHandler(this.chbMuzik_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(470, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Karşılaşmayı Sil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Karşılaşmayı Düzenle";
            // 
            // pboKarsilasmaSil
            // 
            this.pboKarsilasmaSil.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources.football_player_close_up_with_delete_cross_symbol;
            this.pboKarsilasmaSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboKarsilasmaSil.Location = new System.Drawing.Point(424, 511);
            this.pboKarsilasmaSil.Margin = new System.Windows.Forms.Padding(2);
            this.pboKarsilasmaSil.Name = "pboKarsilasmaSil";
            this.pboKarsilasmaSil.Size = new System.Drawing.Size(42, 50);
            this.pboKarsilasmaSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboKarsilasmaSil.TabIndex = 4;
            this.pboKarsilasmaSil.TabStop = false;
            // 
            // pboKarsilasmaDuzenle
            // 
            this.pboKarsilasmaDuzenle.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources.soccer;
            this.pboKarsilasmaDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboKarsilasmaDuzenle.Location = new System.Drawing.Point(10, 95);
            this.pboKarsilasmaDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.pboKarsilasmaDuzenle.Name = "pboKarsilasmaDuzenle";
            this.pboKarsilasmaDuzenle.Size = new System.Drawing.Size(52, 55);
            this.pboKarsilasmaDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboKarsilasmaDuzenle.TabIndex = 3;
            this.pboKarsilasmaDuzenle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(744, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Karşılaşma Ekle";
            // 
            // pboKarsilasmaEkle
            // 
            this.pboKarsilasmaEkle.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources.soccer_field;
            this.pboKarsilasmaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboKarsilasmaEkle.Location = new System.Drawing.Point(944, 95);
            this.pboKarsilasmaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.pboKarsilasmaEkle.Name = "pboKarsilasmaEkle";
            this.pboKarsilasmaEkle.Size = new System.Drawing.Size(53, 64);
            this.pboKarsilasmaEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboKarsilasmaEkle.TabIndex = 1;
            this.pboKarsilasmaEkle.TabStop = false;
            this.pboKarsilasmaEkle.Click += new System.EventHandler(this.pboKarsilasmaEkle_Click);
            // 
            // lviKarsilasma
            // 
            this.lviKarsilasma.BackgroundImageTiled = true;
            this.lviKarsilasma.HideSelection = false;
            this.lviKarsilasma.Location = new System.Drawing.Point(24, 257);
            this.lviKarsilasma.Margin = new System.Windows.Forms.Padding(2);
            this.lviKarsilasma.Name = "lviKarsilasma";
            this.lviKarsilasma.Size = new System.Drawing.Size(963, 239);
            this.lviKarsilasma.TabIndex = 0;
            this.lviKarsilasma.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._700_FO38203752_01f55836a9290b702c39bc2cc1a6d244;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(997, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Takımlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._700_FO38203752_01f55836a9290b702c39bc2cc1a6d244;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.btnTakimOyuncuSil);
            this.groupBox4.Controls.Add(this.btnTakimOyuncuAta);
            this.groupBox4.Controls.Add(this.lstTakimOyunculari);
            this.groupBox4.Controls.Add(this.cboOyuncuAd);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cboTakimAdO);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.LightYellow;
            this.groupBox4.Location = new System.Drawing.Point(634, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(317, 532);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Takıma Oyuncu Ata";
            // 
            // btnTakimOyuncuSil
            // 
            this.btnTakimOyuncuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakimOyuncuSil.ForeColor = System.Drawing.Color.LightYellow;
            this.btnTakimOyuncuSil.Location = new System.Drawing.Point(178, 98);
            this.btnTakimOyuncuSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakimOyuncuSil.Name = "btnTakimOyuncuSil";
            this.btnTakimOyuncuSil.Size = new System.Drawing.Size(127, 28);
            this.btnTakimOyuncuSil.TabIndex = 6;
            this.btnTakimOyuncuSil.Text = "Oyuncu Sil";
            this.btnTakimOyuncuSil.UseVisualStyleBackColor = false;
            this.btnTakimOyuncuSil.Click += new System.EventHandler(this.btnTakimOyuncuSil_Click);
            // 
            // btnTakimOyuncuAta
            // 
            this.btnTakimOyuncuAta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakimOyuncuAta.ForeColor = System.Drawing.Color.LightYellow;
            this.btnTakimOyuncuAta.Location = new System.Drawing.Point(18, 98);
            this.btnTakimOyuncuAta.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakimOyuncuAta.Name = "btnTakimOyuncuAta";
            this.btnTakimOyuncuAta.Size = new System.Drawing.Size(143, 28);
            this.btnTakimOyuncuAta.TabIndex = 5;
            this.btnTakimOyuncuAta.Text = "Oyuncu Ekle";
            this.btnTakimOyuncuAta.UseVisualStyleBackColor = false;
            this.btnTakimOyuncuAta.Click += new System.EventHandler(this.btnTakimOyuncuAta_Click);
            // 
            // lstTakimOyunculari
            // 
            this.lstTakimOyunculari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTakimOyunculari.DisplayMember = "PlayerName";
            this.lstTakimOyunculari.FormattingEnabled = true;
            this.lstTakimOyunculari.ItemHeight = 20;
            this.lstTakimOyunculari.Location = new System.Drawing.Point(61, 136);
            this.lstTakimOyunculari.Margin = new System.Windows.Forms.Padding(2);
            this.lstTakimOyunculari.Name = "lstTakimOyunculari";
            this.lstTakimOyunculari.Size = new System.Drawing.Size(189, 264);
            this.lstTakimOyunculari.TabIndex = 4;
            this.lstTakimOyunculari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTakimAdlari_KeyDown);
            // 
            // cboOyuncuAd
            // 
            this.cboOyuncuAd.DisplayMember = "PlayerName";
            this.cboOyuncuAd.FormattingEnabled = true;
            this.cboOyuncuAd.Location = new System.Drawing.Point(132, 68);
            this.cboOyuncuAd.Margin = new System.Windows.Forms.Padding(2);
            this.cboOyuncuAd.Name = "cboOyuncuAd";
            this.cboOyuncuAd.Size = new System.Drawing.Size(173, 28);
            this.cboOyuncuAd.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Oyuncu :";
            // 
            // cboTakimAdO
            // 
            this.cboTakimAdO.DisplayMember = "TeamName";
            this.cboTakimAdO.FormattingEnabled = true;
            this.cboTakimAdO.Location = new System.Drawing.Point(132, 29);
            this.cboTakimAdO.Margin = new System.Windows.Forms.Padding(2);
            this.cboTakimAdO.Name = "cboTakimAdO";
            this.cboTakimAdO.Size = new System.Drawing.Size(173, 28);
            this.cboTakimAdO.TabIndex = 1;
            this.cboTakimAdO.SelectedIndexChanged += new System.EventHandler(this.cboTakimAdO_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightYellow;
            this.label8.Location = new System.Drawing.Point(14, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Takım Adı :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._700_FO38203752_01f55836a9290b702c39bc2cc1a6d244;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btnTakimRenkSil);
            this.groupBox3.Controls.Add(this.btnTakimRenkAta);
            this.groupBox3.Controls.Add(this.lstTakiminRengi);
            this.groupBox3.Controls.Add(this.cboRenkAd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboTakimAd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightYellow;
            this.groupBox3.Location = new System.Drawing.Point(308, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(311, 529);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Takıma Renk Ata";
            // 
            // btnTakimRenkSil
            // 
            this.btnTakimRenkSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakimRenkSil.Location = new System.Drawing.Point(215, 98);
            this.btnTakimRenkSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakimRenkSil.Name = "btnTakimRenkSil";
            this.btnTakimRenkSil.Size = new System.Drawing.Size(90, 28);
            this.btnTakimRenkSil.TabIndex = 6;
            this.btnTakimRenkSil.Text = "Renk Sil";
            this.btnTakimRenkSil.UseVisualStyleBackColor = false;
            this.btnTakimRenkSil.Click += new System.EventHandler(this.btnTakimRenkSil_Click);
            // 
            // btnTakimRenkAta
            // 
            this.btnTakimRenkAta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakimRenkAta.Location = new System.Drawing.Point(121, 98);
            this.btnTakimRenkAta.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakimRenkAta.Name = "btnTakimRenkAta";
            this.btnTakimRenkAta.Size = new System.Drawing.Size(88, 28);
            this.btnTakimRenkAta.TabIndex = 5;
            this.btnTakimRenkAta.Text = "Renk Ata";
            this.btnTakimRenkAta.UseVisualStyleBackColor = false;
            this.btnTakimRenkAta.Click += new System.EventHandler(this.btnTakimRenkAta_Click);
            // 
            // lstTakiminRengi
            // 
            this.lstTakiminRengi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTakiminRengi.DisplayMember = "ColorName";
            this.lstTakiminRengi.FormattingEnabled = true;
            this.lstTakiminRengi.ItemHeight = 20;
            this.lstTakiminRengi.Location = new System.Drawing.Point(61, 136);
            this.lstTakiminRengi.Margin = new System.Windows.Forms.Padding(2);
            this.lstTakiminRengi.Name = "lstTakiminRengi";
            this.lstTakiminRengi.Size = new System.Drawing.Size(189, 264);
            this.lstTakiminRengi.TabIndex = 4;
            this.lstTakiminRengi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTakimAdlari_KeyDown);
            // 
            // cboRenkAd
            // 
            this.cboRenkAd.DisplayMember = "ColorName";
            this.cboRenkAd.FormattingEnabled = true;
            this.cboRenkAd.Location = new System.Drawing.Point(121, 64);
            this.cboRenkAd.Margin = new System.Windows.Forms.Padding(2);
            this.cboRenkAd.Name = "cboRenkAd";
            this.cboRenkAd.Size = new System.Drawing.Size(184, 28);
            this.cboRenkAd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(2, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Takım Rengi :";
            // 
            // cboTakimAd
            // 
            this.cboTakimAd.DisplayMember = "TeamName";
            this.cboTakimAd.FormattingEnabled = true;
            this.cboTakimAd.Location = new System.Drawing.Point(121, 26);
            this.cboTakimAd.Margin = new System.Windows.Forms.Padding(2);
            this.cboTakimAd.Name = "cboTakimAd";
            this.cboTakimAd.Size = new System.Drawing.Size(184, 28);
            this.cboTakimAd.TabIndex = 1;
            this.cboTakimAd.SelectedIndexChanged += new System.EventHandler(this.cboTakimAd_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Takım Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._700_FO38203752_01f55836a9290b702c39bc2cc1a6d244;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btnTakimSil);
            this.groupBox2.Controls.Add(this.btnTakimEkle);
            this.groupBox2.Controls.Add(this.lstTakimAdlari);
            this.groupBox2.Controls.Add(this.txtTakimAd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(296, 526);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TakımOluştur";
            // 
            // btnTakimSil
            // 
            this.btnTakimSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakimSil.Location = new System.Drawing.Point(149, 72);
            this.btnTakimSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakimSil.Name = "btnTakimSil";
            this.btnTakimSil.Size = new System.Drawing.Size(126, 29);
            this.btnTakimSil.TabIndex = 4;
            this.btnTakimSil.Text = "Takım Sil";
            this.btnTakimSil.UseVisualStyleBackColor = false;
            this.btnTakimSil.Click += new System.EventHandler(this.btnTakimSil_Click);
            // 
            // btnTakimEkle
            // 
            this.btnTakimEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakimEkle.Location = new System.Drawing.Point(10, 72);
            this.btnTakimEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(126, 29);
            this.btnTakimEkle.TabIndex = 3;
            this.btnTakimEkle.Text = "Takım Ekle";
            this.btnTakimEkle.UseVisualStyleBackColor = false;
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);
            // 
            // lstTakimAdlari
            // 
            this.lstTakimAdlari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTakimAdlari.FormattingEnabled = true;
            this.lstTakimAdlari.ItemHeight = 20;
            this.lstTakimAdlari.Location = new System.Drawing.Point(42, 136);
            this.lstTakimAdlari.Margin = new System.Windows.Forms.Padding(2);
            this.lstTakimAdlari.Name = "lstTakimAdlari";
            this.lstTakimAdlari.Size = new System.Drawing.Size(189, 264);
            this.lstTakimAdlari.TabIndex = 2;
            this.lstTakimAdlari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTakimAdlari_KeyDown);
            // 
            // txtTakimAd
            // 
            this.txtTakimAd.Location = new System.Drawing.Point(104, 32);
            this.txtTakimAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtTakimAd.Name = "txtTakimAd";
            this.txtTakimAd.Size = new System.Drawing.Size(170, 26);
            this.txtTakimAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Takım Adı :";
            // 
            // groupBox6
            // 
            this.groupBox6.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._190918_soccer_01;
            this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox6.Controls.Add(this.btnRenkIptal);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.pboSecilenRenk);
            this.groupBox6.Controls.Add(this.btnRenkDuzenle);
            this.groupBox6.Controls.Add(this.btnRenkSil);
            this.groupBox6.Controls.Add(this.btnRenkEkle);
            this.groupBox6.Controls.Add(this.lstRenkler);
            this.groupBox6.Controls.Add(this.pboRenkler);
            this.groupBox6.Controls.Add(this.txtRenkAd);
            this.groupBox6.Controls.Add(this.mtbBDegeri);
            this.groupBox6.Controls.Add(this.mtbGDegeri);
            this.groupBox6.Controls.Add(this.mtbRDegeri);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox6.Location = new System.Drawing.Point(6, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(973, 555);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Renk Atama";
            // 
            // btnRenkIptal
            // 
            this.btnRenkIptal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRenkIptal.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRenkIptal.Location = new System.Drawing.Point(531, 150);
            this.btnRenkIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenkIptal.Name = "btnRenkIptal";
            this.btnRenkIptal.Size = new System.Drawing.Size(144, 35);
            this.btnRenkIptal.TabIndex = 17;
            this.btnRenkIptal.Text = "İPTAL";
            this.btnRenkIptal.UseVisualStyleBackColor = false;
            this.btnRenkIptal.Visible = false;
            this.btnRenkIptal.Click += new System.EventHandler(this.btnRenkIptal_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Info;
            this.label15.Location = new System.Drawing.Point(364, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Renk Paleti";
            // 
            // pboSecilenRenk
            // 
            this.pboSecilenRenk.Location = new System.Drawing.Point(357, 148);
            this.pboSecilenRenk.Margin = new System.Windows.Forms.Padding(2);
            this.pboSecilenRenk.Name = "pboSecilenRenk";
            this.pboSecilenRenk.Size = new System.Drawing.Size(146, 37);
            this.pboSecilenRenk.TabIndex = 15;
            this.pboSecilenRenk.TabStop = false;
            // 
            // btnRenkDuzenle
            // 
            this.btnRenkDuzenle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRenkDuzenle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRenkDuzenle.Location = new System.Drawing.Point(531, 111);
            this.btnRenkDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenkDuzenle.Name = "btnRenkDuzenle";
            this.btnRenkDuzenle.Size = new System.Drawing.Size(144, 35);
            this.btnRenkDuzenle.TabIndex = 14;
            this.btnRenkDuzenle.Text = "Renk Düzenle";
            this.btnRenkDuzenle.UseVisualStyleBackColor = false;
            this.btnRenkDuzenle.Click += new System.EventHandler(this.btnRenkDuzenle_Click);
            // 
            // btnRenkSil
            // 
            this.btnRenkSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRenkSil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRenkSil.Location = new System.Drawing.Point(531, 73);
            this.btnRenkSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenkSil.Name = "btnRenkSil";
            this.btnRenkSil.Size = new System.Drawing.Size(144, 35);
            this.btnRenkSil.TabIndex = 13;
            this.btnRenkSil.Text = "Renk Sil";
            this.btnRenkSil.UseVisualStyleBackColor = false;
            this.btnRenkSil.Click += new System.EventHandler(this.btnRenkSil_Click);
            // 
            // btnRenkEkle
            // 
            this.btnRenkEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRenkEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRenkEkle.Location = new System.Drawing.Point(531, 35);
            this.btnRenkEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenkEkle.Name = "btnRenkEkle";
            this.btnRenkEkle.Size = new System.Drawing.Size(144, 34);
            this.btnRenkEkle.TabIndex = 10;
            this.btnRenkEkle.Text = "Renk Ekle";
            this.btnRenkEkle.UseVisualStyleBackColor = false;
            this.btnRenkEkle.Click += new System.EventHandler(this.btnRenkEkle_Click);
            // 
            // lstRenkler
            // 
            this.lstRenkler.BackColor = System.Drawing.Color.Black;
            this.lstRenkler.DisplayMember = "ColorName";
            this.lstRenkler.ForeColor = System.Drawing.Color.White;
            this.lstRenkler.FormattingEnabled = true;
            this.lstRenkler.ItemHeight = 25;
            this.lstRenkler.Location = new System.Drawing.Point(726, 27);
            this.lstRenkler.Margin = new System.Windows.Forms.Padding(2);
            this.lstRenkler.Name = "lstRenkler";
            this.lstRenkler.Size = new System.Drawing.Size(226, 479);
            this.lstRenkler.TabIndex = 9;
            // 
            // pboRenkler
            // 
            this.pboRenkler.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources.colour;
            this.pboRenkler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboRenkler.Location = new System.Drawing.Point(357, 48);
            this.pboRenkler.Margin = new System.Windows.Forms.Padding(2);
            this.pboRenkler.Name = "pboRenkler";
            this.pboRenkler.Size = new System.Drawing.Size(146, 96);
            this.pboRenkler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboRenkler.TabIndex = 8;
            this.pboRenkler.TabStop = false;
            this.pboRenkler.Click += new System.EventHandler(this.pboRenkler_Click);
            // 
            // txtRenkAd
            // 
            this.txtRenkAd.Location = new System.Drawing.Point(138, 32);
            this.txtRenkAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenkAd.Name = "txtRenkAd";
            this.txtRenkAd.Size = new System.Drawing.Size(179, 30);
            this.txtRenkAd.TabIndex = 7;
            // 
            // mtbBDegeri
            // 
            this.mtbBDegeri.HidePromptOnLeave = true;
            this.mtbBDegeri.Location = new System.Drawing.Point(138, 138);
            this.mtbBDegeri.Margin = new System.Windows.Forms.Padding(2);
            this.mtbBDegeri.Mask = "000";
            this.mtbBDegeri.Name = "mtbBDegeri";
            this.mtbBDegeri.ReadOnly = true;
            this.mtbBDegeri.Size = new System.Drawing.Size(179, 30);
            this.mtbBDegeri.TabIndex = 6;
            this.mtbBDegeri.ValidatingType = typeof(int);
            // 
            // mtbGDegeri
            // 
            this.mtbGDegeri.HidePromptOnLeave = true;
            this.mtbGDegeri.Location = new System.Drawing.Point(138, 101);
            this.mtbGDegeri.Margin = new System.Windows.Forms.Padding(2);
            this.mtbGDegeri.Mask = "000";
            this.mtbGDegeri.Name = "mtbGDegeri";
            this.mtbGDegeri.ReadOnly = true;
            this.mtbGDegeri.Size = new System.Drawing.Size(179, 30);
            this.mtbGDegeri.TabIndex = 5;
            this.mtbGDegeri.ValidatingType = typeof(int);
            // 
            // mtbRDegeri
            // 
            this.mtbRDegeri.HidePromptOnLeave = true;
            this.mtbRDegeri.Location = new System.Drawing.Point(138, 65);
            this.mtbRDegeri.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRDegeri.Mask = "000";
            this.mtbRDegeri.Name = "mtbRDegeri";
            this.mtbRDegeri.ReadOnly = true;
            this.mtbRDegeri.Size = new System.Drawing.Size(179, 30);
            this.mtbRDegeri.TabIndex = 4;
            this.mtbRDegeri.ValidatingType = typeof(int);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(41, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "B Değeri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(41, 101);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "G Değeri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(44, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "R Değeri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(41, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Renk Adı";
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::WeAreTheChampionsWFA.Properties.Resources._8127;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.btnOyuncuIptal);
            this.groupBox5.Controls.Add(this.btnOyuncuDuzenle);
            this.groupBox5.Controls.Add(this.btnOyuncuSil);
            this.groupBox5.Controls.Add(this.btnOyuncuEkle);
            this.groupBox5.Controls.Add(this.lstOyuncular);
            this.groupBox5.Controls.Add(this.txtOyuncuAd);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(1001, 569);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Oyuncu Oluşturma";
            // 
            // btnOyuncuIptal
            // 
            this.btnOyuncuIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOyuncuIptal.ForeColor = System.Drawing.Color.White;
            this.btnOyuncuIptal.Location = new System.Drawing.Point(380, 504);
            this.btnOyuncuIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyuncuIptal.Name = "btnOyuncuIptal";
            this.btnOyuncuIptal.Size = new System.Drawing.Size(120, 30);
            this.btnOyuncuIptal.TabIndex = 11;
            this.btnOyuncuIptal.Text = "İPTAL";
            this.btnOyuncuIptal.UseVisualStyleBackColor = false;
            this.btnOyuncuIptal.Visible = false;
            this.btnOyuncuIptal.Click += new System.EventHandler(this.btnOyuncuIptal_Click);
            // 
            // btnOyuncuDuzenle
            // 
            this.btnOyuncuDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOyuncuDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnOyuncuDuzenle.Location = new System.Drawing.Point(789, 504);
            this.btnOyuncuDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyuncuDuzenle.Name = "btnOyuncuDuzenle";
            this.btnOyuncuDuzenle.Size = new System.Drawing.Size(120, 30);
            this.btnOyuncuDuzenle.TabIndex = 10;
            this.btnOyuncuDuzenle.Text = "DÜZENLE";
            this.btnOyuncuDuzenle.UseVisualStyleBackColor = false;
            this.btnOyuncuDuzenle.Click += new System.EventHandler(this.btnOyuncuDuzenle_Click);
            // 
            // btnOyuncuSil
            // 
            this.btnOyuncuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOyuncuSil.ForeColor = System.Drawing.Color.White;
            this.btnOyuncuSil.Location = new System.Drawing.Point(690, 504);
            this.btnOyuncuSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(82, 31);
            this.btnOyuncuSil.TabIndex = 9;
            this.btnOyuncuSil.Text = "SİL";
            this.btnOyuncuSil.UseVisualStyleBackColor = false;
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOyuncuEkle.ForeColor = System.Drawing.Color.White;
            this.btnOyuncuEkle.Location = new System.Drawing.Point(562, 504);
            this.btnOyuncuEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(122, 31);
            this.btnOyuncuEkle.TabIndex = 8;
            this.btnOyuncuEkle.Text = "EKLE";
            this.btnOyuncuEkle.UseVisualStyleBackColor = false;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // lstOyuncular
            // 
            this.lstOyuncular.BackColor = System.Drawing.Color.AliceBlue;
            this.lstOyuncular.DisplayMember = "PlayerName";
            this.lstOyuncular.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstOyuncular.FormattingEnabled = true;
            this.lstOyuncular.ItemHeight = 25;
            this.lstOyuncular.Location = new System.Drawing.Point(562, 104);
            this.lstOyuncular.Margin = new System.Windows.Forms.Padding(2);
            this.lstOyuncular.Name = "lstOyuncular";
            this.lstOyuncular.Size = new System.Drawing.Size(347, 379);
            this.lstOyuncular.TabIndex = 3;
            // 
            // txtOyuncuAd
            // 
            this.txtOyuncuAd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtOyuncuAd.Location = new System.Drawing.Point(562, 70);
            this.txtOyuncuAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtOyuncuAd.Name = "txtOyuncuAd";
            this.txtOyuncuAd.Size = new System.Drawing.Size(347, 30);
            this.txtOyuncuAd.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(624, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Oyuncunun Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 612);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "We Are The Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboKarsilasmaSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboKarsilasmaDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboKarsilasmaEkle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboSecilenRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenkler)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboKarsilasmaSil;
        private System.Windows.Forms.PictureBox pboKarsilasmaDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboKarsilasmaEkle;
        private System.Windows.Forms.ListView lviKarsilasma;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTakimOyuncuSil;
        private System.Windows.Forms.Button btnTakimOyuncuAta;
        private System.Windows.Forms.ListBox lstTakimOyunculari;
        private System.Windows.Forms.ComboBox cboOyuncuAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTakimAdO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTakimRenkSil;
        private System.Windows.Forms.Button btnTakimRenkAta;
        private System.Windows.Forms.ListBox lstTakiminRengi;
        private System.Windows.Forms.ComboBox cboRenkAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTakimAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTakimSil;
        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.ListBox lstTakimAdlari;
        private System.Windows.Forms.TextBox txtTakimAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstOyuncular;
        private System.Windows.Forms.TextBox txtOyuncuAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstRenkler;
        private System.Windows.Forms.PictureBox pboRenkler;
        private System.Windows.Forms.TextBox txtRenkAd;
        private System.Windows.Forms.MaskedTextBox mtbBDegeri;
        private System.Windows.Forms.MaskedTextBox mtbGDegeri;
        private System.Windows.Forms.MaskedTextBox mtbRDegeri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOyuncuDuzenle;
        private System.Windows.Forms.Button btnOyuncuSil;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.Button btnRenkEkle;
        private System.Windows.Forms.Button btnRenkDuzenle;
        private System.Windows.Forms.Button btnRenkSil;
        private System.Windows.Forms.PictureBox pboSecilenRenk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRenkIptal;
        private System.Windows.Forms.Button btnOyuncuIptal;
        private System.Windows.Forms.CheckBox chbMuzik;
    }
}

