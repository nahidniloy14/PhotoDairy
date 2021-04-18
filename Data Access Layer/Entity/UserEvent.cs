using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer.Entity
{
    class UserEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string ModificationDate { get; set; }
        public int Importance { get; set; }
        public int UserId { get; set; }
    }
}
