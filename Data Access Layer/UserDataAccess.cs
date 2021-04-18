using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer
{
    class UserDataAccess: DataAccess
    {
        public User GetUser(string name, string password) {
            string sql = "SELECT * fROM Users WHERE Name='" + name +"' AND Password='"+password+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read()) {
                User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.Username = reader["Username"].ToString();
                return user;
            }
            return null;
        }

        public int AddUser(User user) {
            string sql = "INSERT INTO Users(Name,Username,Password) VALUES ('"+user.Name+ "', '" + user.Username + "', '" + user.Password + "')";
            return this.ExecuteQuery(sql);
        }
    }
}
