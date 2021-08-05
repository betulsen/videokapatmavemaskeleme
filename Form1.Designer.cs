namespace tezcalisma
{

    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.ileri = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.DosyaIslemleri = new System.Windows.Forms.TabControl();
            this.Dosya = new System.Windows.Forms.TabPage();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.EkranBolme = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.OtomatikMaskeleme = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.Evet = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BolgeselMaskeleme = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DosyaIslemleri.SuspendLayout();
            this.Dosya.SuspendLayout();
            this.EkranBolme.SuspendLayout();
            this.OtomatikMaskeleme.SuspendLayout();
            this.BolgeselMaskeleme.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Görüntüyü Açınız";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Görüntü Özellikleri"});
            this.listBox1.Location = new System.Drawing.Point(25, 441);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 124);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 2);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 20);
            this.label2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(264, 28);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 26);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSaniye
            // 
            this.lblSaniye.BackColor = System.Drawing.Color.Transparent;
            this.lblSaniye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaniye.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaniye.Location = new System.Drawing.Point(354, 26);
            this.lblSaniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(99, 52);
            this.lblSaniye.TabIndex = 12;
            this.lblSaniye.Text = "0";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(181, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(190, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(108, 29);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Alt";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 29);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ust";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(190, 78);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(98, 29);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(66, 24);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.Text = "Sağ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 29);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 24);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sol";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(471, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 41);
            this.button3.TabIndex = 22;
            this.button3.Text = "Maskeleme ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(150, 330);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 50);
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(154, 409);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(53, 45);
            this.simpleButton2.TabIndex = 27;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(214, 374);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(54, 43);
            this.simpleButton3.TabIndex = 28;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton4.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton4.Location = new System.Drawing.Point(96, 369);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(51, 40);
            this.simpleButton4.TabIndex = 29;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // ileri
            // 
            this.ileri.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ileri.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.ileri.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.ileri.Appearance.Options.UseBackColor = true;
            this.ileri.Appearance.Options.UseBorderColor = true;
            this.ileri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ileri.Image = ((System.Drawing.Image)(resources.GetObject("ileri.Image")));
            this.ileri.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.ileri.Location = new System.Drawing.Point(403, 83);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(50, 42);
            this.ileri.TabIndex = 30;
            this.ileri.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton6.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton6.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseBorderColor = true;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton6.Location = new System.Drawing.Point(354, 83);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(52, 44);
            this.simpleButton6.TabIndex = 31;
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton7.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton7.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseBorderColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton7.Location = new System.Drawing.Point(35, 92);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(179, 58);
            this.simpleButton7.TabIndex = 32;
            this.simpleButton7.Text = "Videoya Dönüştür";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton8.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton8.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.Appearance.Options.UseBorderColor = true;
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton8.Location = new System.Drawing.Point(35, 31);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(179, 50);
            this.simpleButton8.TabIndex = 33;
            this.simpleButton8.Text = "Video Seç";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton9.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton9.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton9.Appearance.Options.UseBackColor = true;
            this.simpleButton9.Appearance.Options.UseBorderColor = true;
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton9.Location = new System.Drawing.Point(35, 170);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(179, 53);
            this.simpleButton9.TabIndex = 34;
            this.simpleButton9.Text = "Frame Çıkart";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(181, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 43);
            this.button7.TabIndex = 36;
            this.button7.Text = "Oku";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(71, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 41);
            this.button6.TabIndex = 37;
            this.button6.Text = "Alan Ekle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(71, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 41);
            this.button8.TabIndex = 38;
            this.button8.Text = "Alan Sil";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(71, 305);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 41);
            this.button9.TabIndex = 39;
            this.button9.Text = "Kaydet";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DosyaIslemleri
            // 
            this.DosyaIslemleri.Controls.Add(this.Dosya);
            this.DosyaIslemleri.Controls.Add(this.EkranBolme);
            this.DosyaIslemleri.Controls.Add(this.OtomatikMaskeleme);
            this.DosyaIslemleri.Controls.Add(this.BolgeselMaskeleme);
            this.DosyaIslemleri.Controls.Add(this.tabPage1);
            this.DosyaIslemleri.Location = new System.Drawing.Point(645, 26);
            this.DosyaIslemleri.Name = "DosyaIslemleri";
            this.DosyaIslemleri.RightToLeftLayout = true;
            this.DosyaIslemleri.SelectedIndex = 0;
            this.DosyaIslemleri.Size = new System.Drawing.Size(806, 625);
            this.DosyaIslemleri.TabIndex = 40;
            // 
            // Dosya
            // 
            this.Dosya.BackColor = System.Drawing.Color.Transparent;
            this.Dosya.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dosya.BackgroundImage")));
            this.Dosya.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dosya.Controls.Add(this.simpleButton8);
            this.Dosya.Controls.Add(this.checkBox4);
            this.Dosya.Controls.Add(this.checkBox3);
            this.Dosya.Controls.Add(this.simpleButton7);
            this.Dosya.Controls.Add(this.simpleButton9);
            this.Dosya.Controls.Add(this.listBox1);
            this.Dosya.Location = new System.Drawing.Point(4, 29);
            this.Dosya.Name = "Dosya";
            this.Dosya.Padding = new System.Windows.Forms.Padding(3);
            this.Dosya.Size = new System.Drawing.Size(798, 592);
            this.Dosya.TabIndex = 0;
            this.Dosya.Text = "Dosya İşlemleri";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(47, 291);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 26);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "Önizleme";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(47, 248);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(177, 26);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "Maskeleme Yap";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // EkranBolme
            // 
            this.EkranBolme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EkranBolme.BackgroundImage")));
            this.EkranBolme.Controls.Add(this.checkBox1);
            this.EkranBolme.Controls.Add(this.checkBox2);
            this.EkranBolme.Controls.Add(this.numericUpDown1);
            this.EkranBolme.Controls.Add(this.simpleButton1);
            this.EkranBolme.Controls.Add(this.simpleButton2);
            this.EkranBolme.Controls.Add(this.simpleButton3);
            this.EkranBolme.Controls.Add(this.simpleButton4);
            this.EkranBolme.Controls.Add(this.groupBox1);
            this.EkranBolme.Controls.Add(this.groupBox2);
            this.EkranBolme.Location = new System.Drawing.Point(4, 29);
            this.EkranBolme.Name = "EkranBolme";
            this.EkranBolme.Padding = new System.Windows.Forms.Padding(3);
            this.EkranBolme.Size = new System.Drawing.Size(798, 592);
            this.EkranBolme.TabIndex = 1;
            this.EkranBolme.Text = "Ekran Bölme";
            this.EkranBolme.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(31, 13);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 26);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Yatay";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(31, 47);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 26);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Dikey";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // OtomatikMaskeleme
            // 
            this.OtomatikMaskeleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OtomatikMaskeleme.BackgroundImage")));
            this.OtomatikMaskeleme.Controls.Add(this.button11);
            this.OtomatikMaskeleme.Controls.Add(this.button10);
            this.OtomatikMaskeleme.Controls.Add(this.button5);
            this.OtomatikMaskeleme.Controls.Add(this.button4);
            this.OtomatikMaskeleme.Controls.Add(this.checkBox10);
            this.OtomatikMaskeleme.Controls.Add(this.checkBox9);
            this.OtomatikMaskeleme.Controls.Add(this.checkBox8);
            this.OtomatikMaskeleme.Controls.Add(this.checkBox7);
            this.OtomatikMaskeleme.Controls.Add(this.checkBox6);
            this.OtomatikMaskeleme.Controls.Add(this.Evet);
            this.OtomatikMaskeleme.Controls.Add(this.label7);
            this.OtomatikMaskeleme.Controls.Add(this.label5);
            this.OtomatikMaskeleme.Controls.Add(this.label4);
            this.OtomatikMaskeleme.Location = new System.Drawing.Point(4, 29);
            this.OtomatikMaskeleme.Name = "OtomatikMaskeleme";
            this.OtomatikMaskeleme.Padding = new System.Windows.Forms.Padding(3);
            this.OtomatikMaskeleme.Size = new System.Drawing.Size(798, 592);
            this.OtomatikMaskeleme.TabIndex = 2;
            this.OtomatikMaskeleme.Text = "Otomatik Maskeleme";
            this.OtomatikMaskeleme.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button11.Location = new System.Drawing.Point(138, 436);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(186, 51);
            this.button11.TabIndex = 18;
            this.button11.Text = "Görüntü Seç";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button10.Location = new System.Drawing.Point(141, 507);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(183, 50);
            this.button10.TabIndex = 17;
            this.button10.Text = "Görüntü Maskele";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(371, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 51);
            this.button5.TabIndex = 16;
            this.button5.Text = "Video Seç";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(371, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "Video Maskele";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(318, 378);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(81, 24);
            this.checkBox10.TabIndex = 14;
            this.checkBox10.Text = "Video";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(141, 378);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(101, 24);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Text = "Görüntü";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(138, 245);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(213, 24);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Hayır Herkesi Maskele";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(138, 215);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(287, 24);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "Evet Sadece Çocukları Maskele";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(138, 102);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(76, 24);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Hayır";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Evet
            // 
            this.Evet.AutoSize = true;
            this.Evet.Location = new System.Drawing.Point(138, 72);
            this.Evet.Name = "Evet";
            this.Evet.Size = new System.Drawing.Size(71, 24);
            this.Evet.TabIndex = 9;
            this.Evet.Text = "Evet";
            this.Evet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sadece çocuklara mı maskleme yapılacak?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lütfen maskeleeme yapılacak dosya türünü seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(137, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cinsiyete göre maskeleme yapılacak mı?";
            // 
            // BolgeselMaskeleme
            // 
            this.BolgeselMaskeleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BolgeselMaskeleme.BackgroundImage")));
            this.BolgeselMaskeleme.Controls.Add(this.button8);
            this.BolgeselMaskeleme.Controls.Add(this.button9);
            this.BolgeselMaskeleme.Controls.Add(this.button6);
            this.BolgeselMaskeleme.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BolgeselMaskeleme.Location = new System.Drawing.Point(4, 29);
            this.BolgeselMaskeleme.Name = "BolgeselMaskeleme";
            this.BolgeselMaskeleme.Padding = new System.Windows.Forms.Padding(3);
            this.BolgeselMaskeleme.Size = new System.Drawing.Size(798, 592);
            this.BolgeselMaskeleme.TabIndex = 3;
            this.BolgeselMaskeleme.Text = "Bölgesel Maskeleme";
            this.BolgeselMaskeleme.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 592);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Şifreli Dosya Sıkıştırma";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button12.Location = new System.Drawing.Point(25, 49);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(145, 62);
            this.button12.TabIndex = 0;
            this.button12.Text = "Dosyayı Açınız";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button13.Location = new System.Drawing.Point(25, 388);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(145, 54);
            this.button13.TabIndex = 1;
            this.button13.Text = "Sıkıştır";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(25, 162);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 184);
            this.listBox2.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(206, 39);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(492, 427);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1575, 696);
            this.Controls.Add(this.DosyaIslemleri);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DosyaIslemleri.ResumeLayout(false);
            this.Dosya.ResumeLayout(false);
            this.Dosya.PerformLayout();
            this.EkranBolme.ResumeLayout(false);
            this.EkranBolme.PerformLayout();
            this.OtomatikMaskeleme.ResumeLayout(false);
            this.OtomatikMaskeleme.PerformLayout();
            this.BolgeselMaskeleme.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton ileri;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage Dosya;
        private System.Windows.Forms.TabPage EkranBolme;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TabPage OtomatikMaskeleme;
        public System.Windows.Forms.TabPage BolgeselMaskeleme;
        public System.Windows.Forms.TabControl DosyaIslemleri;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox Evet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
    }
}

