namespace ZeroTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.TAB = new System.Windows.Forms.TabControl();
            this.MAIN = new System.Windows.Forms.TabPage();
            this.ZT_REV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_opentp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SETTINGS = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.RIG = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SEAT = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SUBNET = new System.Windows.Forms.TextBox();
            this.ADDRS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KEY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DNS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpsel = new System.Windows.Forms.Button();
            this.TPtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minimesel = new System.Windows.Forms.Button();
            this.minimetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filesel = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pacagetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DBG_SAVE = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DBG_ESC = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RUNNING = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.SETUP = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TAB.SuspendLayout();
            this.MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SETTINGS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.RUNNING.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(12, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Launch Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_set.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_set.Location = new System.Drawing.Point(12, 265);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(240, 45);
            this.btn_set.TabIndex = 1;
            this.btn_set.Text = "Settings";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // TAB
            // 
            this.TAB.Controls.Add(this.MAIN);
            this.TAB.Controls.Add(this.SETTINGS);
            this.TAB.Controls.Add(this.tabPage1);
            this.TAB.Controls.Add(this.RUNNING);
            this.TAB.Controls.Add(this.SETUP);
            this.TAB.Location = new System.Drawing.Point(-4, -23);
            this.TAB.Name = "TAB";
            this.TAB.SelectedIndex = 0;
            this.TAB.Size = new System.Drawing.Size(660, 395);
            this.TAB.TabIndex = 2;
            // 
            // MAIN
            // 
            this.MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MAIN.Controls.Add(this.ZT_REV);
            this.MAIN.Controls.Add(this.label13);
            this.MAIN.Controls.Add(this.label12);
            this.MAIN.Controls.Add(this.label11);
            this.MAIN.Controls.Add(this.pictureBox1);
            this.MAIN.Controls.Add(this.btn_opentp);
            this.MAIN.Controls.Add(this.button4);
            this.MAIN.Controls.Add(this.btn_set);
            this.MAIN.Controls.Add(this.button1);
            this.MAIN.Location = new System.Drawing.Point(4, 22);
            this.MAIN.Name = "MAIN";
            this.MAIN.Padding = new System.Windows.Forms.Padding(3);
            this.MAIN.Size = new System.Drawing.Size(652, 369);
            this.MAIN.TabIndex = 0;
            this.MAIN.Text = "MAIN";
            this.MAIN.Click += new System.EventHandler(this.MAIN_Click);
            // 
            // ZT_REV
            // 
            this.ZT_REV.AutoSize = true;
            this.ZT_REV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZT_REV.ForeColor = System.Drawing.Color.White;
            this.ZT_REV.Location = new System.Drawing.Point(16, 57);
            this.ZT_REV.Name = "ZT_REV";
            this.ZT_REV.Size = new System.Drawing.Size(129, 21);
            this.ZT_REV.TabIndex = 8;
            this.ZT_REV.Text = "Zero Tool Ver.1.4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(445, 47);
            this.label13.TabIndex = 7;
            this.label13.Text = "InitalD Arcade Stage Zero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(503, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 100);
            this.label12.TabIndex = 6;
            this.label12.Text = "Platform: SEGA Nu\r\nRelease: 2017\r\nNvidia: OK\r\nAmd: OK\r\nintel: NO\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(544, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Create by Kinako";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_opentp
            // 
            this.btn_opentp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_opentp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_opentp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_opentp.Location = new System.Drawing.Point(253, 265);
            this.btn_opentp.Name = "btn_opentp";
            this.btn_opentp.Size = new System.Drawing.Size(240, 45);
            this.btn_opentp.TabIndex = 3;
            this.btn_opentp.Text = "CONTROLLER SETUP";
            this.btn_opentp.UseVisualStyleBackColor = false;
            this.btn_opentp.Click += new System.EventHandler(this.btn_opentp_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(12, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(481, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "Force Exit Game";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SETTINGS
            // 
            this.SETTINGS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SETTINGS.Controls.Add(this.label21);
            this.SETTINGS.Controls.Add(this.RIG);
            this.SETTINGS.Controls.Add(this.label20);
            this.SETTINGS.Controls.Add(this.SEAT);
            this.SETTINGS.Controls.Add(this.btn_save);
            this.SETTINGS.Controls.Add(this.label10);
            this.SETTINGS.Controls.Add(this.label9);
            this.SETTINGS.Controls.Add(this.SUBNET);
            this.SETTINGS.Controls.Add(this.ADDRS);
            this.SETTINGS.Controls.Add(this.label8);
            this.SETTINGS.Controls.Add(this.label7);
            this.SETTINGS.Controls.Add(this.KEY);
            this.SETTINGS.Controls.Add(this.label6);
            this.SETTINGS.Controls.Add(this.SER);
            this.SETTINGS.Controls.Add(this.label5);
            this.SETTINGS.Controls.Add(this.DNS);
            this.SETTINGS.Controls.Add(this.label4);
            this.SETTINGS.Controls.Add(this.tpsel);
            this.SETTINGS.Controls.Add(this.TPtxt);
            this.SETTINGS.Controls.Add(this.label3);
            this.SETTINGS.Controls.Add(this.minimesel);
            this.SETTINGS.Controls.Add(this.minimetxt);
            this.SETTINGS.Controls.Add(this.label2);
            this.SETTINGS.Controls.Add(this.Filesel);
            this.SETTINGS.Controls.Add(this.btn_back);
            this.SETTINGS.Controls.Add(this.pacagetxt);
            this.SETTINGS.Controls.Add(this.label1);
            this.SETTINGS.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.SETTINGS.ForeColor = System.Drawing.Color.White;
            this.SETTINGS.Location = new System.Drawing.Point(4, 22);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Padding = new System.Windows.Forms.Padding(3);
            this.SETTINGS.Size = new System.Drawing.Size(652, 343);
            this.SETTINGS.TabIndex = 1;
            this.SETTINGS.Text = "SETTINGS";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(148, 287);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 15);
            this.label21.TabIndex = 27;
            this.label21.Text = "Region";
            // 
            // RIG
            // 
            this.RIG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RIG.FormattingEnabled = true;
            this.RIG.Items.AddRange(new object[] {
            "JPN",
            "EXP"});
            this.RIG.Location = new System.Drawing.Point(151, 305);
            this.RIG.Name = "RIG";
            this.RIG.Size = new System.Drawing.Size(72, 23);
            this.RIG.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(148, 241);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 15);
            this.label20.TabIndex = 25;
            this.label20.Text = "SEAT";
            // 
            // SEAT
            // 
            this.SEAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SEAT.FormattingEnabled = true;
            this.SEAT.Items.AddRange(new object[] {
            "S",
            "A1",
            "A2",
            "B1",
            "B2"});
            this.SEAT.Location = new System.Drawing.Point(151, 259);
            this.SEAT.Name = "SEAT";
            this.SEAT.Size = new System.Drawing.Size(72, 23);
            this.SEAT.TabIndex = 24;
            this.SEAT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Location = new System.Drawing.Point(505, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(67, 31);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(285, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "SUBNET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(148, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "ADDRSUFFIX";
            // 
            // SUBNET
            // 
            this.SUBNET.Location = new System.Drawing.Point(288, 215);
            this.SUBNET.Name = "SUBNET";
            this.SUBNET.Size = new System.Drawing.Size(131, 23);
            this.SUBNET.TabIndex = 20;
            this.SUBNET.Text = "0.0.0.0";
            this.SUBNET.TextChanged += new System.EventHandler(this.SUBNET_TextChanged);
            // 
            // ADDRS
            // 
            this.ADDRS.Location = new System.Drawing.Point(151, 215);
            this.ADDRS.Name = "ADDRS";
            this.ADDRS.Size = new System.Drawing.Size(131, 23);
            this.ADDRS.TabIndex = 19;
            this.ADDRS.Text = "0";
            this.ADDRS.TextChanged += new System.EventHandler(this.ADDRS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "SegaTool Config";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "ZeroTool Config";
            // 
            // KEY
            // 
            this.KEY.Location = new System.Drawing.Point(14, 305);
            this.KEY.Name = "KEY";
            this.KEY.Size = new System.Drawing.Size(131, 23);
            this.KEY.TabIndex = 16;
            this.KEY.Text = "AAVE-01A13990000";
            this.KEY.TextChanged += new System.EventHandler(this.KEY_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "KEYCHIP";
            // 
            // SER
            // 
            this.SER.Location = new System.Drawing.Point(14, 259);
            this.SER.Name = "SER";
            this.SER.Size = new System.Drawing.Size(131, 23);
            this.SER.TabIndex = 14;
            this.SER.Text = "AAVE-01A13990000";
            this.SER.TextChanged += new System.EventHandler(this.SER_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "SERIALNO";
            // 
            // DNS
            // 
            this.DNS.Location = new System.Drawing.Point(14, 215);
            this.DNS.Name = "DNS";
            this.DNS.Size = new System.Drawing.Size(131, 23);
            this.DNS.TabIndex = 12;
            this.DNS.Text = "0.0.0.0";
            this.DNS.TextChanged += new System.EventHandler(this.DNS_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "DEFAULT DNS";
            // 
            // tpsel
            // 
            this.tpsel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tpsel.ForeColor = System.Drawing.Color.Black;
            this.tpsel.Location = new System.Drawing.Point(369, 133);
            this.tpsel.Name = "tpsel";
            this.tpsel.Size = new System.Drawing.Size(27, 19);
            this.tpsel.TabIndex = 10;
            this.tpsel.Text = "...";
            this.tpsel.UseVisualStyleBackColor = true;
            this.tpsel.Click += new System.EventHandler(this.tpsel_Click);
            // 
            // TPtxt
            // 
            this.TPtxt.Location = new System.Drawing.Point(14, 133);
            this.TPtxt.Name = "TPtxt";
            this.TPtxt.Size = new System.Drawing.Size(356, 23);
            this.TPtxt.TabIndex = 9;
            this.TPtxt.TextChanged += new System.EventHandler(this.TPtxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "TeknoParrot Folder";
            // 
            // minimesel
            // 
            this.minimesel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minimesel.ForeColor = System.Drawing.Color.Black;
            this.minimesel.Location = new System.Drawing.Point(369, 96);
            this.minimesel.Name = "minimesel";
            this.minimesel.Size = new System.Drawing.Size(27, 19);
            this.minimesel.TabIndex = 7;
            this.minimesel.Text = "...";
            this.minimesel.UseVisualStyleBackColor = true;
            this.minimesel.Click += new System.EventHandler(this.minimesel_Click);
            // 
            // minimetxt
            // 
            this.minimetxt.Location = new System.Drawing.Point(14, 96);
            this.minimetxt.Name = "minimetxt";
            this.minimetxt.Size = new System.Drawing.Size(356, 23);
            this.minimetxt.TabIndex = 6;
            this.minimetxt.TextChanged += new System.EventHandler(this.minimetxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "minime Folder";
            // 
            // Filesel
            // 
            this.Filesel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Filesel.ForeColor = System.Drawing.Color.Black;
            this.Filesel.Location = new System.Drawing.Point(369, 59);
            this.Filesel.Name = "Filesel";
            this.Filesel.Size = new System.Drawing.Size(27, 19);
            this.Filesel.TabIndex = 4;
            this.Filesel.Text = "...";
            this.Filesel.UseVisualStyleBackColor = true;
            this.Filesel.Click += new System.EventHandler(this.Filesel_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_back.Location = new System.Drawing.Point(578, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(67, 31);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pacagetxt
            // 
            this.pacagetxt.Location = new System.Drawing.Point(14, 59);
            this.pacagetxt.Name = "pacagetxt";
            this.pacagetxt.Size = new System.Drawing.Size(356, 23);
            this.pacagetxt.TabIndex = 2;
            this.pacagetxt.TextChanged += new System.EventHandler(this.pacagetxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "package Folder";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DBG_SAVE);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.DBG_ESC);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 368);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "DEBUG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DBG_SAVE
            // 
            this.DBG_SAVE.AutoSize = true;
            this.DBG_SAVE.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBG_SAVE.Location = new System.Drawing.Point(6, 57);
            this.DBG_SAVE.Name = "DBG_SAVE";
            this.DBG_SAVE.Size = new System.Drawing.Size(181, 30);
            this.DBG_SAVE.TabIndex = 3;
            this.DBG_SAVE.Text = "保存されていません";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "保存";
            // 
            // DBG_ESC
            // 
            this.DBG_ESC.AutoSize = true;
            this.DBG_ESC.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DBG_ESC.Location = new System.Drawing.Point(6, 15);
            this.DBG_ESC.Name = "DBG_ESC";
            this.DBG_ESC.Size = new System.Drawing.Size(61, 27);
            this.DBG_ESC.TabIndex = 1;
            this.DBG_ESC.Text = "OFF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "ESCキーの状態";
            // 
            // RUNNING
            // 
            this.RUNNING.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RUNNING.Controls.Add(this.label19);
            this.RUNNING.Controls.Add(this.label18);
            this.RUNNING.Controls.Add(this.button2);
            this.RUNNING.Controls.Add(this.label17);
            this.RUNNING.Location = new System.Drawing.Point(4, 22);
            this.RUNNING.Name = "RUNNING";
            this.RUNNING.Padding = new System.Windows.Forms.Padding(3);
            this.RUNNING.Size = new System.Drawing.Size(652, 368);
            this.RUNNING.TabIndex = 3;
            this.RUNNING.Text = "RUNNING";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(144, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(362, 65);
            this.label19.TabIndex = 5;
            this.label19.Text = "Game Running";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(79, 309);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(485, 30);
            this.label18.TabIndex = 4;
            this.label18.Text = "Exit Game on Press Esc Key or EXIT GAME Button";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(208, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT GAME\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(160, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(328, 37);
            this.label17.TabIndex = 0;
            this.label17.Text = "InitalD Arcade Stage Zero";
            // 
            // SETUP
            // 
            this.SETUP.Location = new System.Drawing.Point(4, 22);
            this.SETUP.Name = "SETUP";
            this.SETUP.Padding = new System.Windows.Forms.Padding(3);
            this.SETUP.Size = new System.Drawing.Size(652, 368);
            this.SETUP.TabIndex = 4;
            this.SETUP.Text = "SETUP";
            this.SETUP.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 365);
            this.Controls.Add(this.TAB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ZeroTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TAB.ResumeLayout(false);
            this.MAIN.ResumeLayout(false);
            this.MAIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SETTINGS.ResumeLayout(false);
            this.SETTINGS.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.RUNNING.ResumeLayout(false);
            this.RUNNING.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.TabControl TAB;
        private System.Windows.Forms.TabPage MAIN;
        private System.Windows.Forms.TabPage SETTINGS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox pacagetxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Filesel;
        private System.Windows.Forms.Button minimesel;
        private System.Windows.Forms.TextBox minimetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_opentp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button tpsel;
        private System.Windows.Forms.TextBox TPtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KEY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SUBNET;
        private System.Windows.Forms.TextBox ADDRS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ZT_REV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DBG_ESC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label DBG_SAVE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage RUNNING;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox SEAT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox RIG;
        private System.Windows.Forms.TabPage SETUP;
    }
}

