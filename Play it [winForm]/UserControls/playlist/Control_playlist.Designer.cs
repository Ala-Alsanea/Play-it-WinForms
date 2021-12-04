namespace Play_it__winForm_.UserControls.playlist
{
    partial class Control_playlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.btn_browse = new Guna.UI2.WinForms.Guna2Button();
            this.DGV_PL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_playlistName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Animated = true;
            this.btn_Delete.BorderRadius = 10;
            this.btn_Delete.CheckedState.Parent = this.btn_Delete;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.CustomImages.Parent = this.btn_Delete;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FillColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btn_Delete.HoverState.Parent = this.btn_Delete;
            this.btn_Delete.Location = new System.Drawing.Point(873, 436);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(107, 57);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_next
            // 
            this.btn_next.Animated = true;
            this.btn_next.BorderRadius = 10;
            this.btn_next.CheckedState.Parent = this.btn_next;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.CustomImages.Parent = this.btn_next;
            this.btn_next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_next.HoverState.Parent = this.btn_next;
            this.btn_next.Location = new System.Drawing.Point(922, 534);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.ShadowDecoration.Parent = this.btn_next;
            this.btn_next.Size = new System.Drawing.Size(107, 45);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = "NEXT";
            // 
            // btn_browse
            // 
            this.btn_browse.Animated = true;
            this.btn_browse.BorderRadius = 10;
            this.btn_browse.CheckedState.Parent = this.btn_browse;
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.CustomImages.Parent = this.btn_browse;
            this.btn_browse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btn_browse.HoverState.Parent = this.btn_browse;
            this.btn_browse.Location = new System.Drawing.Point(744, 436);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.ShadowDecoration.Parent = this.btn_browse;
            this.btn_browse.Size = new System.Drawing.Size(107, 57);
            this.btn_browse.TabIndex = 11;
            this.btn_browse.Text = "Browse";
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // DGV_PL
            // 
            this.DGV_PL.AllowUserToAddRows = false;
            this.DGV_PL.AllowUserToDeleteRows = false;
            this.DGV_PL.AllowUserToResizeColumns = false;
            this.DGV_PL.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DGV_PL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_PL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PL.BackgroundColor = System.Drawing.Color.White;
            this.DGV_PL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_PL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_PL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_PL.ColumnHeadersHeight = 50;
            this.DGV_PL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_PL.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PL.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_PL.EnableHeadersVisualStyles = false;
            this.DGV_PL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PL.Location = new System.Drawing.Point(51, 95);
            this.DGV_PL.Name = "DGV_PL";
            this.DGV_PL.ReadOnly = true;
            this.DGV_PL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_PL.RowHeadersVisible = false;
            this.DGV_PL.RowHeadersWidth = 50;
            this.DGV_PL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PL.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_PL.RowTemplate.Height = 24;
            this.DGV_PL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PL.Size = new System.Drawing.Size(978, 319);
            this.DGV_PL.StandardTab = true;
            this.DGV_PL.TabIndex = 8;
            this.DGV_PL.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGV_PL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_PL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_PL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_PL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_PL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_PL.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_PL.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_PL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV_PL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_PL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_PL.ThemeStyle.HeaderStyle.Height = 50;
            this.DGV_PL.ThemeStyle.ReadOnly = true;
            this.DGV_PL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_PL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_PL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV_PL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PL.ThemeStyle.RowsStyle.Height = 24;
            this.DGV_PL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_PL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PL_CellClick);
            // 
            // lbl_playlistName
            // 
            this.lbl_playlistName.AutoSize = true;
            this.lbl_playlistName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playlistName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_playlistName.Location = new System.Drawing.Point(45, 27);
            this.lbl_playlistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_playlistName.Name = "lbl_playlistName";
            this.lbl_playlistName.Size = new System.Drawing.Size(76, 32);
            this.lbl_playlistName.TabIndex = 7;
            this.lbl_playlistName.Text = "name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_back
            // 
            this.btn_back.Animated = true;
            this.btn_back.BorderRadius = 10;
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(51, 534);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(107, 45);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "BACK";
            // 
            // Control_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.DGV_PL);
            this.Controls.Add(this.lbl_playlistName);
            this.Name = "Control_playlist";
            this.Size = new System.Drawing.Size(1075, 607);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_browse;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_PL;
        private System.Windows.Forms.Label lbl_playlistName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btn_back;
    }
}
