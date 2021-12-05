namespace Play_it__winForm_
{
    partial class Form_mediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mediaPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_openFile = new Guna.UI2.WinForms.Guna2Button();
            this.trackBar_media = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_inProgress = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_min = new Guna.UI2.WinForms.Guna2Button();
            this.btn_max = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.elipse_form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_start = new Guna.UI2.WinForms.Guna2Button();
            this.btn_plus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_minus = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_soundBar = new Guna.UI2.WinForms.Guna2Button();
            this.trackBar_voice = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.btn_mute = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btn_minus);
            this.panel1.Controls.Add(this.btn_mute);
            this.panel1.Controls.Add(this.btn_soundBar);
            this.panel1.Controls.Add(this.btn_plus);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btn_openFile);
            this.panel1.Controls.Add(this.trackBar_media);
            this.panel1.Controls.Add(this.lbl_inProgress);
            this.panel1.Controls.Add(this.lbl_duration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 113);
            this.panel1.TabIndex = 0;
            // 
            // btn_openFile
            // 
            this.btn_openFile.Animated = true;
            this.btn_openFile.BorderRadius = 10;
            this.btn_openFile.CheckedState.Parent = this.btn_openFile;
            this.btn_openFile.CustomImages.Parent = this.btn_openFile;
            this.btn_openFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_openFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_openFile.ForeColor = System.Drawing.Color.White;
            this.btn_openFile.HoverState.Parent = this.btn_openFile;
            this.btn_openFile.Image = global::Play_it__winForm_.Properties.Resources.Puls_2x;
            this.btn_openFile.Location = new System.Drawing.Point(26, 71);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.ShadowDecoration.Parent = this.btn_openFile;
            this.btn_openFile.Size = new System.Drawing.Size(104, 30);
            this.btn_openFile.TabIndex = 4;
            this.btn_openFile.Text = "Browse";
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // trackBar_media
            // 
            this.trackBar_media.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_media.FillColor = System.Drawing.Color.White;
            this.trackBar_media.HoverState.Parent = this.trackBar_media;
            this.trackBar_media.Location = new System.Drawing.Point(90, 16);
            this.trackBar_media.Name = "trackBar_media";
            this.trackBar_media.Size = new System.Drawing.Size(991, 23);
            this.trackBar_media.TabIndex = 0;
            this.trackBar_media.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.trackBar_media.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_media_Scroll);
            // 
            // lbl_inProgress
            // 
            this.lbl_inProgress.AutoSize = true;
            this.lbl_inProgress.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inProgress.ForeColor = System.Drawing.Color.White;
            this.lbl_inProgress.Location = new System.Drawing.Point(3, 16);
            this.lbl_inProgress.Name = "lbl_inProgress";
            this.lbl_inProgress.Size = new System.Drawing.Size(81, 20);
            this.lbl_inProgress.TabIndex = 0;
            this.lbl_inProgress.Text = "00:00:00";
            // 
            // lbl_duration
            // 
            this.lbl_duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.White;
            this.lbl_duration.Location = new System.Drawing.Point(1082, 16);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(81, 20);
            this.lbl_duration.TabIndex = 0;
            this.lbl_duration.Text = "00:00:00";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pnl_top.Controls.Add(this.btn_back);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.btn_min);
            this.pnl_top.Controls.Add(this.btn_max);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lbl_text);
            this.pnl_top.Controls.Add(this.pictureBox2);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1163, 33);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.DoubleClick += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_back
            // 
            this.btn_back.Animated = true;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Image = global::Play_it__winForm_.Properties.Resources.Arrow_2_2x;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(44, 33);
            this.btn_back.TabIndex = 7;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(114, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(52, 20);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Play it";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Animated = true;
            this.btn_min.BackColor = System.Drawing.SystemColors.Control;
            this.btn_min.CheckedState.Parent = this.btn_min;
            this.btn_min.CustomImages.Parent = this.btn_min;
            this.btn_min.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_min.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.HoverState.Parent = this.btn_min;
            this.btn_min.Image = global::Play_it__winForm_.Properties.Resources.min3;
            this.btn_min.Location = new System.Drawing.Point(1052, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.ShadowDecoration.Parent = this.btn_min;
            this.btn_min.Size = new System.Drawing.Size(33, 33);
            this.btn_min.TabIndex = 5;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.Animated = true;
            this.btn_max.BackColor = System.Drawing.SystemColors.Control;
            this.btn_max.CheckedState.Parent = this.btn_max;
            this.btn_max.CustomImages.Parent = this.btn_max;
            this.btn_max.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_max.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.Color.White;
            this.btn_max.HoverState.Parent = this.btn_max;
            this.btn_max.Image = global::Play_it__winForm_.Properties.Resources.maxSquare2;
            this.btn_max.Location = new System.Drawing.Point(1091, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.ShadowDecoration.Parent = this.btn_max;
            this.btn_max.Size = new System.Drawing.Size(33, 33);
            this.btn_max.TabIndex = 5;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Animated = true;
            this.btn_close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(1130, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(33, 33);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.ForeColor = System.Drawing.Color.White;
            this.lbl_text.Location = new System.Drawing.Point(68, 9);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(0, 19);
            this.lbl_text.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Play_it__winForm_.Properties.Resources.logo_icon;
            this.pictureBox2.Location = new System.Drawing.Point(50, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnl_top;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 0;
            this.elipse_form.TargetControl = this;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_start.Animated = true;
            this.btn_start.BorderRadius = 20;
            this.btn_start.CheckedState.Parent = this.btn_start;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.CustomImages.Parent = this.btn_start;
            this.btn_start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btn_start.HoverState.Parent = this.btn_start;
            this.btn_start.Image = global::Play_it__winForm_.Properties.Resources.logo_icon_1_3x;
            this.btn_start.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_start.Location = new System.Drawing.Point(551, 45);
            this.btn_start.Name = "btn_start";
            this.btn_start.ShadowDecoration.Parent = this.btn_start;
            this.btn_start.Size = new System.Drawing.Size(60, 60);
            this.btn_start.TabIndex = 1;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // btn_plus
            // 
            this.btn_plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_plus.Animated = true;
            this.btn_plus.BorderRadius = 20;
            this.btn_plus.CheckedState.Parent = this.btn_plus;
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.CustomImages.Parent = this.btn_plus;
            this.btn_plus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_plus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btn_plus.HoverState.Parent = this.btn_plus;
            this.btn_plus.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_plus.Location = new System.Drawing.Point(642, 61);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.ShadowDecoration.Parent = this.btn_plus;
            this.btn_plus.Size = new System.Drawing.Size(40, 40);
            this.btn_plus.TabIndex = 1;
            this.btn_plus.Text = "+10s";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_minus.Animated = true;
            this.btn_minus.BorderRadius = 20;
            this.btn_minus.CheckedState.Parent = this.btn_minus;
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.CustomImages.Parent = this.btn_minus;
            this.btn_minus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_minus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btn_minus.HoverState.Parent = this.btn_minus;
            this.btn_minus.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_minus.Location = new System.Drawing.Point(476, 61);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.ShadowDecoration.Parent = this.btn_minus;
            this.btn_minus.Size = new System.Drawing.Size(40, 40);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.Text = "-10s";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackBar_voice);
            this.panel2.Controls.Add(this.pic_logo);
            this.panel2.Controls.Add(this.wmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 489);
            this.panel2.TabIndex = 1;
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_logo.Image = global::Play_it__winForm_.Properties.Resources.logo_icon_1_3x;
            this.pic_logo.Location = new System.Drawing.Point(412, 177);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(344, 214);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 4;
            this.pic_logo.TabStop = false;
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(1163, 489);
            this.wmp.TabIndex = 3;
            // 
            // btn_soundBar
            // 
            this.btn_soundBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_soundBar.Animated = true;
            this.btn_soundBar.BorderRadius = 9;
            this.btn_soundBar.CheckedState.Parent = this.btn_soundBar;
            this.btn_soundBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_soundBar.CustomImages.Parent = this.btn_soundBar;
            this.btn_soundBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_soundBar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soundBar.ForeColor = System.Drawing.Color.White;
            this.btn_soundBar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btn_soundBar.HoverState.Parent = this.btn_soundBar;
            this.btn_soundBar.Image = global::Play_it__winForm_.Properties.Resources.high_vioce;
            this.btn_soundBar.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_soundBar.Location = new System.Drawing.Point(1091, 61);
            this.btn_soundBar.Name = "btn_soundBar";
            this.btn_soundBar.ShadowDecoration.Parent = this.btn_soundBar;
            this.btn_soundBar.Size = new System.Drawing.Size(40, 40);
            this.btn_soundBar.TabIndex = 1;
            this.btn_soundBar.Click += new System.EventHandler(this.btn_soundBar_Click);
            // 
            // trackBar_voice
            // 
            this.trackBar_voice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_voice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar_voice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.trackBar_voice.HoverState.Parent = this.trackBar_voice;
            this.trackBar_voice.Location = new System.Drawing.Point(1091, 177);
            this.trackBar_voice.Name = "trackBar_voice";
            this.trackBar_voice.Size = new System.Drawing.Size(23, 300);
            this.trackBar_voice.TabIndex = 5;
            this.trackBar_voice.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.trackBar_voice.Visible = false;
            this.trackBar_voice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_voice_Scroll);
            // 
            // btn_mute
            // 
            this.btn_mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mute.Animated = true;
            this.btn_mute.BorderRadius = 9;
            this.btn_mute.CheckedState.Parent = this.btn_mute;
            this.btn_mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mute.CustomImages.Parent = this.btn_mute;
            this.btn_mute.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_mute.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mute.ForeColor = System.Drawing.Color.White;
            this.btn_mute.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btn_mute.HoverState.Parent = this.btn_mute;
            this.btn_mute.Image = global::Play_it__winForm_.Properties.Resources.low_voice;
            this.btn_mute.ImageSize = new System.Drawing.Size(25, 30);
            this.btn_mute.Location = new System.Drawing.Point(1041, 61);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.ShadowDecoration.Parent = this.btn_mute;
            this.btn_mute.Size = new System.Drawing.Size(40, 40);
            this.btn_mute.TabIndex = 1;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_Click);
            // 
            // Form_mediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_mediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_mediaPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar_media;
        private System.Windows.Forms.Label lbl_inProgress;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btn_min;
        private Guna.UI2.WinForms.Guna2Button btn_max;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_openFile;
        private Guna.UI2.WinForms.Guna2Button btn_start;
        private Guna.UI2.WinForms.Guna2Button btn_minus;
        private Guna.UI2.WinForms.Guna2Button btn_plus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_logo;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private Guna.UI2.WinForms.Guna2Button btn_soundBar;
        private Guna.UI2.WinForms.Guna2VTrackBar trackBar_voice;
        private Guna.UI2.WinForms.Guna2Button btn_mute;
    }
}

