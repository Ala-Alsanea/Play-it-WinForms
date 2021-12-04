using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_it__winForm_.UserControls.playlist.Classes
{
    class Playlist
    {

        //vAr
        private string toDB = Properties.Settings.Default.ToDB;

        private string selectTemp = "select id , name , path,  playlist_ID from PlaylistS ";
        private string insertTemp = "Insert into PlaylistS (name,path) Values (@NAME,@PATH)";

        private string select = "select id , name , path,  playlist_ID from PlaylistS where playlist_ID=@PLAYLIST_ID ";
        private string insert = "Insert into PlaylistS (name,path,playlist_ID) Values (@NAME,@PATH,@PLAYLIST_ID)";
        private string delete = "Delete from PlaylistS  where Id=@ID";


        //property
        public string ID { get; set; }
        public string NAME { get; set; }

        public string PATH { get; set; }

        public string PLAYLIST_ID { get; set; }


        // fun ### unedited

                // temp fun
        public DataTable getData()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectTemp, connection))
                {
                    
                    (new SqlDataAdapter(command)).Fill(data);
                }
            }

            return data;

        }



        public DataTable getData(Playlist Obj)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    command.Parameters.AddWithValue("@PLAYLIST_ID", Obj.PLAYLIST_ID);
                    (new SqlDataAdapter(command)).Fill(data);
                }
            }

            return data;

        }


        public void AddMedia(Playlist Obj)
        {
            int row = 0;

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertTemp, connection))
                {
                    command.Parameters.AddWithValue("@NAME", Obj.NAME);
                    command.Parameters.AddWithValue("@PATH", Obj.PATH);
                   // command.Parameters.AddWithValue("@PLAYLIST_ID", 0);
                    row = command.ExecuteNonQuery();
                }

            }


        }


        public void DeleteMedia(Playlist Obj)
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
