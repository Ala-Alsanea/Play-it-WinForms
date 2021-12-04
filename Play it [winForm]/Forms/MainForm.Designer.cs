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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_min = new Guna.UI2.WinForms.Guna2Button();
            this.btn_max = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_top.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 0;
            this.elipse_form.TargetControl = this;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.pnl_top.Controls.Add(this.ibi_title);
            this.pnl_top.Controls.Add(this.panel3);
            this.pnl_top.Controls.Add(this.btn_min);
            this.pnl_top.Controls.Add(this.btn_max);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.lbl_text);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1333, 41);
            this.pnl_top.TabIndex = 1;
            // 
            // ibi_title
            // 
            this.ibi_title.AutoSize = true;
            this.ibi_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibi_title.ForeColor = System.Drawing.Color.White;
            this.ibi_title.Location = new System.Drawing.Point(283, 11);
            this.ibi_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ibi_title.Name = "ibi_title";
            this.ibi_title.Size = new System.Drawing.Size(52, 20);
            this.ibi_title.TabIndex = 6;
            this.ibi_title.Text = "Play it";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(178)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 42);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Play_it__winForm_.Properties.Resources.logo_icon;
            this.pictureBox2.Location = new System.Drawing.Point(89, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            this.btn_min.Location = new System.Drawing.Point(1185, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.ShadowDecoration.Parent = this.btn_min;
            this.btn_min.Size = new System.Drawing.Size(44, 41);
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
            this.btn_max.Location = new System.Drawing.Point(1237, 0);
            this.btn_max.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_max.Name = "btn_max";
            this.btn_max.ShadowDecoration.Parent = this.btn_max;
            this.btn_max.Size = new System.Drawing.Size(44, 41);
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
            this.btn_close.Location = new System.Drawing.Point(1289, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(44, 41);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.ForeColor = System.Drawing.Color.White;
            this.lbl_text.Location = new System.Drawing.Point(91, 11);
            this.lbl_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(0, 17);
            this.lbl_text.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnl_top;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.btn_Playlist);
            this.panel1.Controls.Add(this.btn_OpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 606);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.lbl_version);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 38);
            this.panel2.TabIndex = 1;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.White;
            this.lbl_version.Location = new System.Drawing.Point(83, 6);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(66, 33);
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
            this.guna2Button3.Location = new System.Drawing.Point(28, 283);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(199, 55);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "YTD";
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
            this.btn_Playlist.Location = new System.Drawing.Point(28, 171);
            this.btn_Playlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.ShadowDecoration.Parent = this.btn_Playlist;
            this.btn_Playlist.Size = new System.Drawing.Size(199, 55);
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
            this.btn_OpenFile.Location = new System.Drawing.Point(28, 66);
            this.btn_OpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.ShadowDecoration.Parent = this.btn_OpenFile;
            this.btn_OpenFile.Size = new System.Drawing.Size(199, 55);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open file";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // pnl_switch
            // 
            this.pnl_switch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_switch.Location = new System.Drawing.Point(259, 41);
            this.pnl_switch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_switch.Name = "pnl_switch";
            this.pnl_switch.Size = new System.Drawing.Size(1075, 607);
            this.pnl_switch.TabIndex = 3;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.panel3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 647);
            this.Controls.Add(this.pnl_switch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
        private System.Windows.Forms.Panel pnl_top;
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
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label ibi_title;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}