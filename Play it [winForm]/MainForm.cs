﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play_it__winForm_.UserControls.openFile;

namespace Play_it__winForm_
{
    public partial class MainForm : Form
    {
        //variable


        //property
        


        //function
        void clearPnl(Panel p)
        {
            
        }


        //auto Function


        public MainForm()
        {
            InitializeComponent();
            Control_OpenFile op = new Control_OpenFile();
            pnl_switch.Controls.Add(op);
            op.Dock = DockStyle.Fill;
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
    }
}
