using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play_it__winForm_.UserControls.playlist.Classes;

namespace Play_it__winForm_.UserControls.playlist
{
    public partial class Control_playlist : UserControl
    {
        // vAr
        private Playlist pl = new Playlist();
        private Control_ListOfPlaylist LOPs;

        //Fun





        //gen fun

        public Control_playlist()
        {
            InitializeComponent();
           
            DGV_PL.DataSource = pl.getData(pl);

            DGV_PL.Columns[0].Visible = false;
            DGV_PL.Columns[2].Visible = false;
            DGV_PL.Columns[3].Visible = false;

        }

        public Control_playlist(string FK , string playlistName)
        {
            InitializeComponent();
            pl.PLAYLIST_ID = FK;
            lbl_playlistName.Text = playlistName;
            DGV_PL.DataSource = pl.getData(pl);

            DGV_PL.Columns[0].Visible = false;
            DGV_PL.Columns[2].Visible = false;
            DGV_PL.Columns[3].Visible = false;
        }



        private void btn_browse_Click(object sender, EventArgs e)
        {
            lbl_playlistName.Text = pl.PLAYLIST_ID;


            btn_Delete.Enabled = false;
            openFileDialog1.Filter = " video(*.mp4)|*.mp4| Audio(*.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pl.NAME = openFileDialog1.SafeFileName;
                pl.PATH = openFileDialog1.FileName;
                
                pl.AddMedia(pl);

                DGV_PL.DataSource = pl.getData(pl);

                
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            pl.DeleteMedia(pl);
            btn_Delete.Enabled = false;
            DGV_PL.DataSource = pl.getData(pl);
        }

        private void DGV_PL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int i = e.RowIndex;
                pl.ID = DGV_PL.Rows[i].Cells[0].Value.ToString();
                pl.NAME = DGV_PL.Rows[i].Cells[1].Value.ToString();
                pl.PATH = DGV_PL.Rows[i].Cells[2].Value.ToString();
                pl.PATH = DGV_PL.Rows[i].Cells[3].Value.ToString();
                btn_Delete.Enabled = true;

            }
            catch (Exception exception)
            {
               
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LOPs = new Control_ListOfPlaylist();

            ControlCollection control = MainForm.ActiveForm.ActiveControl.Parent.Controls;

            
            LOPs.Dock = DockStyle.Fill;
            control.Clear();
            control.Add(LOPs);
            LOPs.BringToFront();
        }
    }
}
