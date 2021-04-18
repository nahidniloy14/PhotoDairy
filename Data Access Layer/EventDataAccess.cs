using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer
{
    class EventDataAccess: DataAccess
    {
        public List<UserEvent> GetEvents(int id)
        {
            string sql = "SELECT * fROM Events WHERE UserId=" + id+"ORDER BY IMPORTANCE DESC";
            SqlDataReader reader = this.GetData(sql);
            List<UserEvent> events = new List<UserEvent>();
            while (reader.Read()) {
                UserEvent userEvent = new UserEvent();
                userEvent.EventId = Convert.ToInt32(reader["EventId"]);
                userEvent.EventName = reader["Name"].ToString();
                userEvent.EventDate = reader["EventDate"].ToString();
                userEvent.ModificationDate = reader["ModificationDate"].ToString();
                events.Add(userEvent);
            }
            return events;
        }

        public UserEvent GetEvent(string eventName, int eventId)
        {
            string sql = "SELECT EventId,Name,EventDate,ModificationDate,UserId fROM Events WHERE  Name ='"+eventName+"'AND EventId=" + eventId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                UserEvent userEvent = new UserEvent();
                userEvent.EventId = Convert.ToInt32(reader["EventId"]);
                userEvent.EventName = reader["Name"].ToString();
                userEvent.EventDate = reader["EventDate"].ToString();
                userEvent.ModificationDate = reader["ModificationDate"].ToString();
                userEvent.UserId = Convert.ToInt32(reader["UserId"]);
                return userEvent;
            }
            return null;
        }

        public int AddEvent(UserEvent userEvent)
         {
            string sql = "INSERT INTO Events(Name,EventDate,ModificationDate,Importance,UserId) VALUES ('" + userEvent.EventName + "', '" + userEvent.EventDate + "','" + userEvent.ModificationDate + "'," + userEvent.Importance + "," + userEvent.UserId + ")";
             return this.ExecuteQuery(sql);
         }

        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM Events WHERE EventID=" +id;
            return this.ExecuteQuery(sql);
        }
    }
}
