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
        Bitmap StateImgBtn = global::Play_it__winForm_.Properties.Resources.logo_icon_1_3x;
        Bitmap PauseImgBtn = global::Play_it__winForm_.Properties.Resources.pause_button;


        //property

        //func
        void startMedia()
        {
            wmp.Ctlcontrols.play();
            btn_start.Image = PauseImgBtn;
        }



        //gen func
      public Form_mediaPlayer()
        {
            InitializeComponent();
            trackBar_media.Value = 0;
        }

      public Form_mediaPlayer(string f, string p)
      {
          InitializeComponent();
          trackBar_media.Value = 0;

          file = f;
          path = p;
          wmp.URL = path;
          startMedia();
          timer1.Start();
          pic_logo.Visible = false;


      }



        private void trackBar_voice_Scroll(object sender, ScrollEventArgs e)
        {
            wmp.settings.volume = trackBar_voice.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if (wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    trackBar_media.Maximum = (int) wmp.Ctlcontrols.currentItem.duration;
                    trackBar_media.Value = (int) wmp.Ctlcontrols.currentPosition;

                }

                lbl_inProgress.Text = wmp.Ctlcontrols.currentPositionString;
                lbl_duration.Text = wmp.Ctlcontrols.currentItem.durationString;

                        // when media reach to the end
                if (trackBar_media.Value == trackBar_media.Maximum)
                {
                    timer1.Stop();
                    btn_start.Image = StateImgBtn;
                    trackBar_media.Value = 0;
                    lbl_duration.Text = "00:00:00";
                    lbl_inProgress.Text = "00:00"; 
                    wmp.Ctlcontrols.stop();

                }
            }
            catch (Exception exception)
            {
                timer1.Stop();
                MessageBox.Show(exception.ToString());
                

            }

            
           

        }

        private void trackBar_media_Scroll(object sender, ScrollEventArgs e)
        {
            wmp.Ctlcontrols.currentPosition = trackBar_media.Value;
        }

        

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_max_Click(object sender, EventArgs e)
        {
            int round=0;
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

        private void btn_back_Click(object sender, EventArgs e)
        {

            MainForm m = new MainForm();
            m.Show();
            this.Close();
        }

        private void btn_start_Click_1(object sender, EventArgs e)
        {

            if(wmp.URL == null)
                return;

            if (wmp.playState != WMPLib.WMPPlayState.wmppsPaused )
            {
                btn_start.Image = StateImgBtn;
                wmp.Ctlcontrols.pause();
                return;
            }


            if (wmp.URL != null)
            {
                btn_start.Image = PauseImgBtn;
                wmp.Ctlcontrols.play();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (wmp.URL == null)
                return;

            wmp.Ctlcontrols.currentPosition -= 10;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (wmp.URL == null)
                return;

            wmp.Ctlcontrols.currentPosition += 10;
        }

        private void btn_soundBar_Click(object sender, EventArgs e)
        {

            if (wmp.settings.mute)
            {
                wmp.settings.mute = false;
                return;
            }

            if (trackBar_voice.Visible)
            {
                trackBar_voice.Visible = false;
                return;
            }

            trackBar_voice.Visible = true;
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            wmp.settings.mute = true;
            trackBar_voice.Visible = false;
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " video(*.mp4)|*.mp4| Audio(*.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;
                //lbl_text.Text = (wmp.Ctlcontrols.currentItem.duration == null)?"null": wmp.Ctlcontrols.currentItem.durationString;
                wmp.URL = path;
                wmp.Ctlcontrols.play();
                wmp.settings.enableErrorDialogs = true;
                wmp.settings.volume = trackBar_voice.Value;
                wmp.settings.mute = false;
                timer1.Start();
                pic_logo.Hide();

                btn_start.Image = PauseImgBtn;

                lbl_title.Text += " ( " + file + " )";

            }
        }
    }
}
