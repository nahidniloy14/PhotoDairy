using DigitalPhotoDiary.DataAccessLayer;
using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.BusinessLayer
{
    class EventsService
    {
        EventDataAccess eventDataAccess;
        public EventsService()
        {

            this.eventDataAccess = new EventDataAccess();
        }

        public List<UserEvent> GetEvents(int id)
        {

            return this.eventDataAccess.GetEvents(id);
        }

        public UserEvent GetUserEvent(string eventName, int eventId)
        {

            return this.eventDataAccess.GetEvent(eventName, eventId);
        }

        public int AddNewEvent(string name, string eventDate, string modificationDate, int importance, int userId)
        {

            UserEvent userEvent = new UserEvent() { EventName = name, EventDate = eventDate, ModificationDate = modificationDate, Importance = importance, UserId = userId };
            return this.eventDataAccess.AddEvent(userEvent);
        }

        public int DeleteEvent(int eventId)
        {

            return this.eventDataAccess.DeleteEvent(eventId);
        }
    }
}
