﻿namespace Play_it__winForm_
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
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_inProgress = new System.Windows.Forms.Label();
            this.trackBar_media = new Guna.UI2.WinForms.Guna2TrackBar();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar_voice = new Guna.UI2.WinForms.Guna2TrackBar();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minus10 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_pause = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_previous = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.btn_plus10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_openFile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_plus10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_openFile);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.btn_plus10);
            this.panel1.Controls.Add(this.btn_minus10);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_previous);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.trackBar_voice);
            this.panel1.Controls.Add(this.trackBar_media);
            this.panel1.Controls.Add(this.lbl_inProgress);
            this.panel1.Controls.Add(this.lbl_duration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 99);
            this.panel1.TabIndex = 0;
            // 
            // lbl_duration
            // 
            this.lbl_duration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.White;
            this.lbl_duration.Location = new System.Drawing.Point(905, 16);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(58, 17);
            this.lbl_duration.TabIndex = 0;
            this.lbl_duration.Text = "00:00:00";
            // 
            // lbl_inProgress
            // 
            this.lbl_inProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_inProgress.AutoSize = true;
            this.lbl_inProgress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inProgress.ForeColor = System.Drawing.Color.White;
            this.lbl_inProgress.Location = new System.Drawing.Point(3, 16);
            this.lbl_inProgress.Name = "lbl_inProgress";
            this.lbl_inProgress.Size = new System.Drawing.Size(58, 17);
            this.lbl_inProgress.TabIndex = 0;
            this.lbl_inProgress.Text = "00:00:00";
            // 
            // trackBar_media
            // 
            this.trackBar_media.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_media.FillColor = System.Drawing.Color.White;
            this.trackBar_media.HoverState.Parent = this.trackBar_media;
            this.trackBar_media.Location = new System.Drawing.Point(59, 16);
            this.trackBar_media.Name = "trackBar_media";
            this.trackBar_media.Size = new System.Drawing.Size(847, 23);
            this.trackBar_media.TabIndex = 0;
            this.trackBar_media.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.trackBar_media.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_media_Scroll);
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(963, 421);
            this.wmp.TabIndex = 1;
            // 
            // trackBar_voice
            // 
            this.trackBar_voice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar_voice.FillColor = System.Drawing.Color.White;
            this.trackBar_voice.HoverState.Parent = this.trackBar_voice;
            this.trackBar_voice.Location = new System.Drawing.Point(740, 51);
            this.trackBar_voice.Name = "trackBar_voice";
            this.trackBar_voice.Size = new System.Drawing.Size(166, 23);
            this.trackBar_voice.TabIndex = 0;
            this.trackBar_voice.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.trackBar_voice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_voice_Scroll);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pnl_top.Controls.Add(this.lbl_text);
            this.pnl_top.Controls.Add(this.pictureBox2);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(963, 33);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.DoubleClick += new System.EventHandler(this.pnl_top_DoubleClick);
            // 
            // btn_minus10
            // 
            this.btn_minus10.Image = global::Play_it__winForm_.Properties.Resources.btn_minus_10s;
            this.btn_minus10.Location = new System.Drawing.Point(412, 51);
            this.btn_minus10.Name = "btn_minus10";
            this.btn_minus10.Size = new System.Drawing.Size(30, 30);
            this.btn_minus10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minus10.TabIndex = 3;
            this.btn_minus10.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Play_it__winForm_.Properties.Resources.logo_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pause.Image = global::Play_it__winForm_.Properties.Resources.pause_button;
            this.btn_pause.Location = new System.Drawing.Point(463, 45);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(40, 40);
            this.btn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pause.TabIndex = 3;
            this.btn_pause.TabStop = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::Play_it__winForm_.Properties.Resources.start_button;
            this.btn_start.Location = new System.Drawing.Point(463, 45);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(40, 40);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_start.TabIndex = 3;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Image = global::Play_it__winForm_.Properties.Resources.pervious_button;
            this.btn_previous.Location = new System.Drawing.Point(357, 48);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(35, 35);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_previous.TabIndex = 3;
            this.btn_previous.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.Image = global::Play_it__winForm_.Properties.Resources.next_button;
            this.btn_next.Location = new System.Drawing.Point(576, 48);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(35, 35);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 3;
            this.btn_next.TabStop = false;
            // 
            // btn_plus10
            // 
            this.btn_plus10.Image = global::Play_it__winForm_.Properties.Resources.btn_plus_10s;
            this.btn_plus10.Location = new System.Drawing.Point(526, 51);
            this.btn_plus10.Name = "btn_plus10";
            this.btn_plus10.Size = new System.Drawing.Size(30, 30);
            this.btn_plus10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_plus10.TabIndex = 3;
            this.btn_plus10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = global::Play_it__winForm_.Properties.Resources.low_voice;
            this.pictureBox9.Location = new System.Drawing.Point(714, 51);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 23);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.Image = global::Play_it__winForm_.Properties.Resources.high_vioce;
            this.pictureBox10.Location = new System.Drawing.Point(913, 48);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 31);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnl_top;
            // 
            // btn_openFile
            // 
            this.btn_openFile.CheckedState.Parent = this.btn_openFile;
            this.btn_openFile.CustomImages.Parent = this.btn_openFile;
            this.btn_openFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_openFile.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.btn_openFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.ForeColor = System.Drawing.Color.White;
            this.btn_openFile.HoverState.Parent = this.btn_openFile;
            this.btn_openFile.Location = new System.Drawing.Point(32, 51);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.ShadowDecoration.Parent = this.btn_openFile;
            this.btn_openFile.Size = new System.Drawing.Size(98, 36);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Open file";
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.ForeColor = System.Drawing.Color.White;
            this.lbl_text.Location = new System.Drawing.Point(68, 9);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(38, 13);
            this.lbl_text.TabIndex = 4;
            this.lbl_text.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_mediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 520);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_mediaPlayer";
            this.Text = "Form_mediaPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_plus10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar_media;
        private System.Windows.Forms.Label lbl_inProgress;
        private System.Windows.Forms.Label lbl_duration;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar_voice;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox btn_minus10;
        private System.Windows.Forms.PictureBox btn_next;
        private System.Windows.Forms.PictureBox btn_previous;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_pause;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox btn_plus10;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

