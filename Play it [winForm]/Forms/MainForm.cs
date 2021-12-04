using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play_it__winForm_.UserControls.openFile;
using Play_it__winForm_.UserControls.playlist;
using Guna.UI2;
using Guna.UI2.WinForms;

namespace Play_it__winForm_
{
    public partial class MainForm : Form
    {
        //variable
        

        //property
        
            

        //function
        void userControl_open(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnl_switch.Controls.Clear();
            pnl_switch.Controls.Add(uc);
            //uc.BringToFront();

        }

        void restBtnColor(params Guna2Button [] btns)
        {
            foreach (var btn in btns)
            {
                btn.FillColor = Color.FromArgb(255, 48, 171, 242);
            }

        }

        //auto Function


        public MainForm()
        {
            InitializeComponent();
            btn_Playlist.PerformClick();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            int round = 0;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btn_max.Image = Properties.Resources.max3;
                round = elipse_form.BorderRadius;
                elipse_form.BorderRadius = 0;
                return;
            }
            this.WindowState = FormWindowState.Normal;
            btn_max.Image = Properties.Resources.maxSquare2;
            elipse_form.BorderRadius = round;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            Control_OpenFile openFile = new Control_OpenFile();

            userControl_open(openFile);
            Guna2Button btn = (Guna2Button)sender;
            restBtnColor(btn_OpenFile, btn_Playlist);
            btn.FillColor = Color.FromArgb(255, 40, 127, 178);
        



    }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            Control_ListOfPlaylist cp = new Control_ListOfPlaylist();
            userControl_open(cp);
            Guna2Button btn = (Guna2Button)sender;
            restBtnColor(btn_OpenFile,btn_Playlist);
            btn.FillColor = Color.FromArgb(255, 40, 127, 178);
        }
    }
}
