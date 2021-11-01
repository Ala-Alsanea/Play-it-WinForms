using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play_it__winForm_
{
    public partial class Form_mediaPlayer : Form
    {

        //ver
        private string path, file;

        private bool isMax = false;
        //property

        //func

        //gen func
      public Form_mediaPlayer()
        {
            InitializeComponent();
        }

        private void pnl_top_DoubleClick(object sender, EventArgs e)
        {
            //if (isMax)
            //{
            //    this.WindowState = FormWindowState.Normal;
            //    isMax = false;
            //    return;
                
            //}

            this.WindowState = FormWindowState.Maximized;
            isMax = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void trackBar_voice_Scroll(object sender, ScrollEventArgs e)
        {
            wmp.settings.volume = trackBar_voice.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // init track bar
            if (wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar_media.Maximum = (int) wmp.Ctlcontrols.currentItem.duration;
                trackBar_media.Value = (int)wmp.Ctlcontrols.currentPosition;
            }

            lbl_inProgress.Text = wmp.Ctlcontrols.currentPositionString;
            lbl_duration.Text = wmp.Ctlcontrols.currentItem.durationString;

            // when media reach to th end
            if (trackBar_media.Value == trackBar_media.Maximum)
            {
                timer1.Stop();
                btn_start.Show();
                btn_pause.Hide();
                trackBar_media.Value = 0;
                lbl_duration.Text = "00:00:00";
                lbl_inProgress.Text = "00:00";

            }

        }

        private void trackBar_media_Scroll(object sender, ScrollEventArgs e)
        {
            //wmp.Ctlcontrols.currentPosition = trackBar_media.Value;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (wmp.URL != null)
            {
                wmp.Ctlcontrols.play();
                btn_start.Hide();
                btn_pause.Show();

            }
 
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (wmp.URL != null)
            {
                wmp.Ctlcontrols.pause();
                btn_pause.Hide();
                btn_start.Show();

            }
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;
                //lbl_text.Text = (wmp.Ctlcontrols.currentItem.duration == null)?"null": wmp.Ctlcontrols.currentItem.durationString;
                wmp.URL = path;
                wmp.Ctlcontrols.play();
                wmp.settings.enableErrorDialogs = true;
                wmp.settings.mute = false;
                timer1.Start();
                btn_start.Hide();
                btn_pause.Show();

            }
        }
    }
}
