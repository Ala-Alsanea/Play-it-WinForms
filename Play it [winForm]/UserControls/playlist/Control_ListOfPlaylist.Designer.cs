namespace Play_it__winForm_.UserControls.playlist
{
    partial class Control_ListOfPlaylist
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_PLs = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGV_PLs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PLs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_PLs);
            this.panel1.Controls.Add(this.DGV_PLs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 607);
            this.panel1.TabIndex = 1;
            // 
            // txt_PLs
            // 
            this.txt_PLs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.txt_PLs.BorderRadius = 10;
            this.txt_PLs.BorderThickness = 2;
            this.txt_PLs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PLs.DefaultText = "";
            this.txt_PLs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PLs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PLs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PLs.DisabledState.Parent = this.txt_PLs;
            this.txt_PLs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PLs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PLs.FocusedState.Parent = this.txt_PLs;
            this.txt_PLs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PLs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.txt_PLs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PLs.HoverState.Parent = this.txt_PLs;
            this.txt_PLs.Location = new System.Drawing.Point(46, 395);
            this.txt_PLs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_PLs.Name = "txt_PLs";
            this.txt_PLs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_PLs.PasswordChar = '\0';
            this.txt_PLs.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_PLs.PlaceholderText = "Write Here";
            this.txt_PLs.SelectedText = "";
            this.txt_PLs.ShadowDecoration.Parent = this.txt_PLs;
            this.txt_PLs.Size = new System.Drawing.Size(574, 57);
            this.txt_PLs.TabIndex = 4;
            // 
            // DGV_PLs
            // 
            this.DGV_PLs.AllowUserToAddRows = false;
            this.DGV_PLs.AllowUserToDeleteRows = false;
            this.DGV_PLs.AllowUserToResizeColumns = false;
            this.DGV_PLs.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.DGV_PLs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.DGV_PLs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PLs.BackgroundColor = System.Drawing.Color.White;
            this.DGV_PLs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_PLs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_PLs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PLs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DGV_PLs.ColumnHeadersHeight = 50;
            this.DGV_PLs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_PLs.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PLs.DefaultCellStyle = dataGridViewCellStyle23;
            this.DGV_PLs.EnableHeadersVisualStyles = false;
            this.DGV_PLs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PLs.Location = new System.Drawing.Point(46, 103);
            this.DGV_PLs.Name = "DGV_PLs";
            this.DGV_PLs.ReadOnly = true;
            this.DGV_PLs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_PLs.RowHeadersVisible = false;
            this.DGV_PLs.RowHeadersWidth = 50;
            this.DGV_PLs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PLs.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DGV_PLs.RowTemplate.Height = 24;
            this.DGV_PLs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PLs.Size = new System.Drawing.Size(978, 273);
            this.DGV_PLs.StandardTab = true;
            this.DGV_PLs.TabIndex = 3;
            this.DGV_PLs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGV_PLs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_PLs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_PLs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_PLs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_PLs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_PLs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_PLs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PLs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PLs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_PLs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV_PLs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_PLs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_PLs.ThemeStyle.HeaderStyle.Height = 50;
            this.DGV_PLs.ThemeStyle.ReadOnly = true;
            this.DGV_PLs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_PLs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_PLs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV_PLs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PLs.ThemeStyle.RowsStyle.Height = 24;
            this.DGV_PLs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_PLs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.DGV_PLs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PLs_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = " Playlist";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.BorderRadius = 10;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(630, 395);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(107, 57);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Animated = true;
            this.btn_update.BorderRadius = 10;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.Enabled = false;
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Location = new System.Drawing.Point(745, 395);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(107, 57);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            this.btn_Delete.Location = new System.Drawing.Point(860, 395);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(107, 57);
            this.btn_Delete.TabIndex = 6;
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
            this.btn_next.Location = new System.Drawing.Point(917, 544);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.ShadowDecoration.Parent = this.btn_next;
            this.btn_next.Size = new System.Drawing.Size(107, 45);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "NEXT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(91, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Control_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_playlist";
            this.Size = new System.Drawing.Size(1075, 607);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PLs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_PLs;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_PLs;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
