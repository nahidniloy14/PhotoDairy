using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer
{
    class PhotoDataAccess: DataAccess
    {
        public List<Photo> GetPhotos(int eventId)
        {
            string sql = "SELECT * fROM Photos WHERE EventId=" + eventId;
            SqlDataReader reader = this.GetData(sql);
            List<Photo> photos = new List<Photo>();
            while (reader.Read())
            {
                Photo Photo = new Photo();
                //userEvent.EventId = Convert.ToInt32(reader["UserId"]);
                Photo.PhotoName = reader["Name"].ToString();
                Photo.Directory = reader["Directory"].ToString();
                Photo.Story = reader["Story"].ToString();
                Photo.EventId = Convert.ToInt32(reader["EventId"]);
                photos.Add(Photo);
            }
            return photos;
        }

       
        public int AddPhoto(Photo photo)
        {
            string sql = "INSERT INTO Photos(Name,Directory,Story,EventId) VALUES ('" + photo.PhotoName + "', '" + photo.Directory + "','" + photo.Story + "'," + "+)" + photo.EventId;
            return this.ExecuteQuery(sql);
        }

        public int UpdatePhoto(string directory, int photoId)
        {
            string sql = "UPDATE Photos SET Directory='" + directory + "' WHERE PhotoId=" + photoId;
            return this.ExecuteQuery(sql);
        }
        public int UpdateStory(string story, int photoId)
        {
            string sql = "UPDATE Photos SET Story='" + story + "' WHERE PhotoId=" + photoId;
            return this.ExecuteQuery(sql);
        }
    }
}
