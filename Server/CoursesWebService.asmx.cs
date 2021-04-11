using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Server
{
    /// <summary>
    /// Summary description for CoursesWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CoursesWebService : System.Web.Services.WebService
    {

        private DatabaseEntities databaseEntities = new DatabaseEntities();

        /** Users **/
        [WebMethod]
        public List<User> GetUsers()
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Users.ToList();
        }

        [WebMethod]
        public User GetUser(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Users.Find(id);
        }

        [WebMethod]
        public User GetUserByEmail(string email)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Users.Where(user => user.email == email).FirstOrDefault();
        }

        [WebMethod]
        public User CheckLogin(string email, string password)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Users.Where(user => user.email == email && user.password == password).FirstOrDefault();
        }

        [WebMethod]
        public void AddUser(User user)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Users.Add(user);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void EditUser(User user)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            User existingUser = databaseEntities.Users.Find(user.id);

            existingUser.name     = user.name;
            existingUser.email    = user.email;
            existingUser.password = user.password;

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void DeleteUser(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            User existingUser = databaseEntities.Users.Find(id);
            databaseEntities.Users.Remove(existingUser);

            databaseEntities.SaveChanges();
        }
    }
}
