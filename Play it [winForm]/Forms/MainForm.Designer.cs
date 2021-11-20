namespace Play_it__winForm_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.elipse_form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_top = new System.Windows.Forms.Panel();
            this.ibi_title = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Playlist = new Guna.UI2.WinForms.Guna2Button();
            this.btn_OpenFile = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_switch = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_min = new Guna.UI2.WinForms.Guna2Button();
            this.btn_max = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 10;
            this.elipse_form.TargetControl = this;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pnl_top.Controls.Add(this.ibi_title);
            this.pnl_top.Controls.Add(this.btn_min);
            this.pnl_top.Controls.Add(this.btn_max);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lbl_text);
            this.pnl_top.Controls.Add(this.pictureBox2);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(947, 33);
            this.pnl_top.TabIndex = 1;
            // 
            // ibi_title
            // 
            this.ibi_title.AutoSize = true;
            this.ibi_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibi_title.ForeColor = System.Drawing.Color.White;
            this.ibi_title.Location = new System.Drawing.Point(55, 9);
            this.ibi_title.Name = "ibi_title";
            this.ibi_title.Size = new System.Drawing.Size(40, 15);
            this.ibi_title.TabIndex = 6;
            this.ibi_title.Text = "Play it";
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
            this.btn_close.Location = new System.Drawing.Point(914, 0);
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
            this.lbl_text.Size = new System.Drawing.Size(0, 13);
            this.lbl_text.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnl_top;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.btn_Playlist);
            this.panel1.Controls.Add(this.btn_OpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 448);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.lbl_version);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 31);
            this.panel2.TabIndex = 1;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.White;
            this.lbl_version.Location = new System.Drawing.Point(62, 5);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(52, 26);
            this.lbl_version.TabIndex = 0;
            this.lbl_version.Text = "v 0.4";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(21, 295);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(149, 45);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Ahmed Task";
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.Animated = true;
            this.btn_Playlist.BorderRadius = 10;
            this.btn_Playlist.CheckedState.Parent = this.btn_Playlist;
            this.btn_Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Playlist.CustomImages.Parent = this.btn_Playlist;
            this.btn_Playlist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_Playlist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playlist.ForeColor = System.Drawing.Color.White;
            this.btn_Playlist.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btn_Playlist.HoverState.Parent = this.btn_Playlist;
            this.btn_Playlist.Location = new System.Drawing.Point(21, 234);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.ShadowDecoration.Parent = this.btn_Playlist;
            this.btn_Playlist.Size = new System.Drawing.Size(149, 45);
            this.btn_Playlist.TabIndex = 0;
            this.btn_Playlist.Text = "Playlist";
            this.btn_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Animated = true;
            this.btn_OpenFile.BorderRadius = 10;
            this.btn_OpenFile.CheckedState.Parent = this.btn_OpenFile;
            this.btn_OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenFile.CustomImages.Parent = this.btn_OpenFile;
            this.btn_OpenFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_OpenFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.ForeColor = System.Drawing.Color.White;
            this.btn_OpenFile.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btn_OpenFile.HoverState.Parent = this.btn_OpenFile;
            this.btn_OpenFile.Location = new System.Drawing.Point(21, 174);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.ShadowDecoration.Parent = this.btn_OpenFile;
            this.btn_OpenFile.Size = new System.Drawing.Size(149, 45);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open file";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // pnl_switch
            // 
            this.pnl_switch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_switch.Location = new System.Drawing.Point(194, 33);
            this.pnl_switch.Name = "pnl_switch";
            this.pnl_switch.Size = new System.Drawing.Size(753, 448);
            this.pnl_switch.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Play_it__winForm_.Properties.Resources.logo_icon_1_3x;
            this.pictureBox1.Location = new System.Drawing.Point(21, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.btn_min.Location = new System.Drawing.Point(836, 0);
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
            this.btn_max.Location = new System.Drawing.Point(875, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.ShadowDecoration.Parent = this.btn_max;
            this.btn_max.Size = new System.Drawing.Size(33, 33);
            this.btn_max.TabIndex = 5;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Play_it__winForm_.Properties.Resources.logo_icon;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 481);
            this.Controls.Add(this.pnl_switch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label ibi_title;
        private Guna.UI2.WinForms.Guna2Button btn_min;
        private Guna.UI2.WinForms.Guna2Button btn_max;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_switch;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btn_Playlist;
        private Guna.UI2.WinForms.Guna2Button btn_OpenFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_version;
    }
}