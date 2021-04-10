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
    }
}
