using DigitalPhotoDiary.DataAccessLayer;
using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.BusinessLayer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService() {
            
            this.userDataAccess = new UserDataAccess();
        }

        public User GetUser(string name, string password) {

            return this.userDataAccess.GetUser(name, password);
        }

        public int AddNewUser(string name, string userName, string password) {

            User user = new User() { Name = name, Username= userName, Password= password };
            return this.userDataAccess.AddUser(user);
        }
    }
}
