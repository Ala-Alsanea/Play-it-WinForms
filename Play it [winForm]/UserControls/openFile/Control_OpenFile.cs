﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play_it__winForm_.UserControls.openFile
{
    public partial class Control_OpenFile : UserControl
    {

        //variable
        private string file = "";
        private string path = "";


        //property



        //function



        //auto Function
        public Control_OpenFile()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " video(*.mp4)|*.mp4| Audio(*.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;

                Form_mediaPlayer mp;
                MainForm.ActiveForm.Visible = false;
                mp = new Form_mediaPlayer(file, path);
                mp.Show();


            }

        }
    }
}
