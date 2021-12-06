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

     //   private string selectTemp = "select id , name , path,  playlist_ID from PlaylistS ";
        //private string insertTemp = "Insert into PlaylistS (name,path) Values (@NAME,@PATH)";

        private string select = "select id , name , path,  playlist_ID from PlaylistS where playlist_ID=@PLAYLIST_ID ";
        private string insert = "Insert into PlaylistS (name,path,playlist_ID) Values (@NAME,@PATH,@PLAYLIST_ID)";
        private string delete = "Delete from PlaylistS  where Id=@ID";

        private string delete_PL = "Delete from PlaylistS  where playlist_ID=@PLAYLIST_ID";

        //property
        public string ID { get; set; }
        public string NAME { get; set; }

        public string PATH { get; set; }

        public string PLAYLIST_ID { get; set; }


        // fun ### unedited
        


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
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@NAME", Obj.NAME);
                    command.Parameters.AddWithValue("@PATH", Obj.PATH);
                   command.Parameters.AddWithValue("@PLAYLIST_ID", Obj.PLAYLIST_ID);
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


        public void Deleteplaylst(string id)
        {

            int row = 0;

            using (SqlConnection connection = new SqlConnection(toDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(delete_PL, connection))
                {
                    command.Parameters.AddWithValue("@PLAYLIST_ID", id);
                    row = command.ExecuteNonQuery();
                }

            }


        }
    }
}
