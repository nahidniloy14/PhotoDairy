using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer.Entity
{
    class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string Directory { get; set; }
        public string Story { get; set; }
        public int EventId { get; set; }
    }
}
