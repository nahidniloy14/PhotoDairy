using DigitalPhotoDiary.DataAccessLayer;
using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.BusinessLayer
{
    class PhotoService
    {
        PhotoDataAccess photoDataAccess;
        public PhotoService()
        {

            this.photoDataAccess = new PhotoDataAccess();
        }

        public List<Photo> GetPhotos(int eventId)
        {

            return this.photoDataAccess.GetPhotos(eventId);
        }


        public int AddNewPhoto(string name, string diroctory, string story, int eventId)
        {

            Photo photo = new Photo() { PhotoName = name, Directory = diroctory, Story = story, EventId = eventId };
            return this.photoDataAccess.AddPhoto(photo);
        }

        public int UpdatePhoto(string directory, int photoId)
        {

            return this.photoDataAccess.UpdatePhoto(directory, photoId);
        }
        public int UpdateStory(string story, int photoId)
        {

            return this.photoDataAccess.UpdateStory(story, photoId);
        }


    }
}
