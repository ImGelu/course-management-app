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

        /** Roles **/
        [WebMethod]
        public List<Role> GetRoles()
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Roles.ToList();
        }
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

            existingUser.name = user.name;
            existingUser.email = user.email;
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

        /** Courses **/
        [WebMethod]
        public List<Course> GetCourses()
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Courses.ToList();
        }

        [WebMethod]
        public Course GetCourse(int id)
        {
                databaseEntities.Configuration.ProxyCreationEnabled = false;

                return databaseEntities.Courses.Find(id);
         
        }

        [WebMethod]
        public List<Course> GetCourseByName(string name)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Courses.Where(course => course.name == name).ToList();
        }

        [WebMethod]
        public void AddCourse(Course course)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Courses.Add(course);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void EditCourse(Course course)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Course existingCourse = databaseEntities.Courses.Find(course.id);

            existingCourse.content = course.content;
            existingCourse.name = course.name;
            existingCourse.laboratory_hours = course.laboratory_hours;
            existingCourse.laboratory_tutors = course.laboratory_tutors;
            existingCourse.project_hours = course.project_hours;
            existingCourse.project_tutors = course.project_tutors;
            existingCourse.semester = course.semester;
            existingCourse.seminary_hours = course.seminary_hours;
            existingCourse.seminary_tutors = course.seminary_tutors;
            existingCourse.study_level = course.study_level;
            existingCourse.study_year = course.study_year;
            existingCourse.Specialization = course.Specialization;
            existingCourse.specialization_id = course.specialization_id;

            databaseEntities.SaveChanges();
        }
    }
}
