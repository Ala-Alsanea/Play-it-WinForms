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
    public partial class Control_ListOfPlaylist : UserControl
    {
        // vAr
        private ListOfPlaylist LOPLs = new ListOfPlaylist();
        private Control_playlist pl;

        // fun

        void lastSelectrd()
        {
            try
            {
                LOPLs.ID = DGV_PLs.Rows[0].Cells[0].Value.ToString();
                LOPLs.PLAYLIST = DGV_PLs.Rows[0].Cells[1].Value.ToString();
                label1.Text = "( " + LOPLs.ID + " )" + "- " + LOPLs.PLAYLIST;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

        }

        void blockBtns()
        {
            btn_update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_next.Enabled = false;
        }


        void unblockBtns()
        {
            btn_update.Enabled = true;
            btn_Delete.Enabled = true;
            btn_next.Enabled = true;
        }

        // gen fun
        public Control_ListOfPlaylist()
        {
            InitializeComponent();
            DGV_PLs.DataSource = LOPLs.getData();

            DGV_PLs.Columns[0].Visible = false;


            if (DGV_PLs.DataSource != null)
            {
                lastSelectrd();
            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_PLs.Text = txt_PLs.Text.Trim();
            if (txt_PLs.Text != "")
            {
                LOPLs.PLAYLIST = txt_PLs.Text;
                LOPLs.AddPlaylist(LOPLs);


                DGV_PLs.DataSource = LOPLs.getData();

            }
            txt_PLs.Clear();

        }

        private void DGV_PLs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int i = e.RowIndex;
                LOPLs.ID = DGV_PLs.Rows[i].Cells[0].Value.ToString();
                LOPLs.PLAYLIST = DGV_PLs.Rows[i].Cells[1].Value.ToString();
                txt_PLs.Text = LOPLs.PLAYLIST.Trim();
                unblockBtns();

                label1.Text = "( " + LOPLs.ID + " )" + "- " + LOPLs.PLAYLIST;

            }
            catch (Exception exception)
            {
                label1.Text = "( " + LOPLs.ID + " )" + "- " + LOPLs.PLAYLIST;
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            txt_PLs.Text = txt_PLs.Text.Trim();
            if (txt_PLs.Text != "")
            {
                LOPLs.PLAYLIST = txt_PLs.Text;
                LOPLs.UpdatePlaylist(LOPLs);


                DGV_PLs.DataSource = LOPLs.getData();

            }

            txt_PLs.Clear();
            lastSelectrd();
            blockBtns();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Playlist pl = new Playlist();
            pl.Deleteplaylst(LOPLs.ID);

            LOPLs.PLAYLIST = txt_PLs.Text;
            LOPLs.DeletePlaylist(LOPLs);
            DGV_PLs.DataSource = LOPLs.getData();

           

            txt_PLs.Clear();
            lastSelectrd();
            blockBtns();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_PLs.Text == "")
            {
                blockBtns();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            pl = new Control_playlist(LOPLs.ID, LOPLs.PLAYLIST);

            ControlCollection control = MainForm.ActiveForm.ActiveControl.Parent.Controls;
            
            label1.Text = MainForm.ActiveForm.ActiveControl.Parent.Name;
            pl.Dock = DockStyle.Fill;
            control.Clear();
            control.Add(pl);
            pl.BringToFront();
            // this.Hide();

        }
    }
}
