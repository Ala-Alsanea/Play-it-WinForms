using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_it__winForm_.UserControls.playlist
{
    class ListOfPlaylist
    {
        //vAr
        private string toDB = Properties.Settings.Default.ToDB;

        private string select = "select id , playlist from ListOfPlaylistS";
        private string insert = "Insert into ListOfPlaylistS (playlist) Values (@PLAYLIST)";
        private string update = "Update ListOfPlaylistS set playlist=@PLAYLIST where Id=@ID";
        private string delete = "Delete from ListOfPlaylistS where Id=@ID";

        //property
        public string ID { get; set; }
        public string PLAYLIST { get; set; }

        // fun
        public DataTable getData()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command =new SqlCommand(select,connection))
                {
                    (new SqlDataAdapter(command)).Fill(data);
                }
            }

            return data;

        }

        public void AddPlaylist(ListOfPlaylist Obj)
        {
            int row = 0;

            using (SqlConnection connection =new SqlConnection(toDB))
            { 
                connection.Open();
                using (SqlCommand command = new SqlCommand(insert,connection))
                {
                    command.Parameters.AddWithValue("@PLAYLIST", Obj.PLAYLIST);
                    row = command.ExecuteNonQuery();
                }
                
            }

            
        }

        public void UpdatePlaylist(ListOfPlaylist Obj)
        {
            int row = 0;

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(update, connection))
                {
                    command.Parameters.AddWithValue("@PLAYLIST", Obj.PLAYLIST);
                    command.Parameters.AddWithValue("@ID", Obj.ID);
                    row = command.ExecuteNonQuery();
                }

            }

            
        }

        public void DeletePlaylist(ListOfPlaylist Obj)
        {

            int row = 0;

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(delete, connection))
                {
                    command.Parameters.AddWithValue("@ID", Obj.ID);
                    row = command.ExecuteNonQuery();
                }

            }

        }


    }
}
