using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        [WebMethod]
        public List<Role> GetRolesByName(string name)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Roles.Where(role => role.name.Contains(name)).ToList();
        }


        [WebMethod]
        public Role GetRole(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Roles.Find(id);
        }

        [WebMethod]
        public List<Role> GetUserRoles(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Database.SqlQuery<Role>("SELECT t2.* FROM Users2Roles AS t1 INNER JOIN Roles AS t2 ON t1.id_role = t2.id AND t1.id_user = @id", new SqlParameter("@id", id)).ToList();
        }

        [WebMethod]
        public List<User> GetUsersWithRole(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Database.SqlQuery<User>("SELECT t2.* FROM Users2Roles AS t1 INNER JOIN Users AS t2 ON t1.id_user = t2.id AND t1.id_role = @id", new SqlParameter("@id", id)).ToList();
        }

        [WebMethod]
        public void UpdateUserRoles(int id, List<Role> roles)
        { 
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Database.ExecuteSqlCommand("DELETE FROM Users2Roles WHERE id_user = @id", new SqlParameter("@id", id));

            roles.ForEach((role) =>
            {
                if (role != null)
                {
                    databaseEntities.Database.ExecuteSqlCommand("INSERT INTO Users2Roles(id_user, id_role) VALUES(@id_user, @id_role)", new SqlParameter("@id_user", id), new SqlParameter("@id_role", role.id));
                }
            });
        }

        [WebMethod]
        public void AddRole(Role role)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Roles.Add(role);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void EditRole(Role role)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Role existingRole = databaseEntities.Roles.Find(role.id);

            existingRole.name = role.name;

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void DeleteRole(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Role existingRole = databaseEntities.Roles.Find(id);
            databaseEntities.Roles.Remove(existingRole);

            databaseEntities.SaveChanges();
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
        public List<User> GetUsersByName(string name)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Users.Where(user => user.name.Contains(name)).ToList();
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

            return databaseEntities.Courses.Where(course => course.name.Contains(name)).ToList();
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

            existingCourse.name = course.name;
            existingCourse.study_year = course.study_year;
            existingCourse.semester = course.semester;
            existingCourse.study_level = course.study_level;
            existingCourse.credits = course.credits;
            existingCourse.specialization_id = course.specialization_id;
            existingCourse.content = course.content;

            existingCourse.course_hours = course.course_hours;
            existingCourse.laboratory_hours = course.laboratory_hours;
            existingCourse.seminary_hours = course.seminary_hours;
            existingCourse.project_hours = course.project_hours;

            existingCourse.laboratory_tutors = course.laboratory_tutors;
            existingCourse.seminary_tutors = course.seminary_tutors;
            existingCourse.project_tutors = course.project_tutors;

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void DeleteCourse(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Course existingCourse = databaseEntities.Courses.Find(id);
            databaseEntities.Courses.Remove(existingCourse);

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void RedeemCourse(int courseId, int userId)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Users2Courses users2Courses = new Users2Courses();
            users2Courses.id_user = userId;
            users2Courses.id_course = courseId;
            users2Courses.status = 0;

            databaseEntities.Users2Courses.Add(users2Courses);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void SetCourseRedemptionStatus(int courseId, int userId, byte status)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Users2Courses users2Courses = databaseEntities.Users2Courses.Where((item) => item.id_course == courseId).Where((item) => item.id_user == userId).FirstOrDefault();
            users2Courses.status = status;

            databaseEntities.SaveChanges();
        }

        /* Specializations */
        [WebMethod]
        public List<Specialization> GetSpecializations()
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Specializations.ToList();
        }

        [WebMethod]
        public Specialization GetSpecialization(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Specializations.Find(id);

        }

        [WebMethod]
        public List<Specialization> GetSpecializationByName(string name)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Specializations.Where(specialization => specialization.name.Contains(name)).ToList();
        }

        [WebMethod]
        public void AddSpecialization(Specialization specialization)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Specializations.Add(specialization);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void EditSpecialization(Specialization specialization)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Specialization existingSpecialization = databaseEntities.Specializations.Find(specialization.id);

            existingSpecialization.name = specialization.name;
            existingSpecialization.domain_id = specialization.domain_id;

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void DeleteSpecialization(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Specialization existingSpecialization = databaseEntities.Specializations.Find(id);
            databaseEntities.Specializations.Remove(existingSpecialization);

            databaseEntities.SaveChanges();
        }

        /* Domains */
        [WebMethod]
        public List<Domain> GetDomains()
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Domains.ToList();
        }

        [WebMethod]
        public Domain GetDomain(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Domains.Find(id);
        }

        [WebMethod]
        public List<Domain> GetDomainByName(string name)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Domains.Where(domain => domain.name.Contains(name)).ToList();
        }

        [WebMethod]
        public void AddDomain(Domain domain)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Domains.Add(domain);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void EditDomain(Domain domain)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Domain existingDomain = databaseEntities.Domains.Find(domain.id);

            existingDomain.name = domain.name;
            existingDomain.faculty_id = domain.faculty_id;

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void DeleteDomain(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Domain existingDomain = databaseEntities.Domains.Find(id);
            databaseEntities.Domains.Remove(existingDomain);

            databaseEntities.SaveChanges();
        }

        /* Faculties */
        [WebMethod]
        public List<Faculty> GetFaculties()
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Faculties.ToList();
        }

        [WebMethod]
        public Faculty GetFaculty(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Faculties.Find(id);
        }

        [WebMethod]
        public List<Faculty> GetFacultyByName(string name)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            return databaseEntities.Faculties.Where(faculty => faculty.name.Contains(name)).ToList();
        }

        [WebMethod]
        public void AddFaculty(Faculty faculty)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            databaseEntities.Faculties.Add(faculty);
            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void EditFaculty(Faculty faculty)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Faculty existingFaculty = databaseEntities.Faculties.Find(faculty.id);

            existingFaculty.name = faculty.name;
            existingFaculty.website = faculty.website;
            existingFaculty.logo = faculty.logo;

            databaseEntities.SaveChanges();
        }

        [WebMethod]
        public void DeleteFaculty(int id)
        {
            databaseEntities.Configuration.ProxyCreationEnabled = false;

            Faculty existingFaculty = databaseEntities.Faculties.Find(id);
            databaseEntities.Faculties.Remove(existingFaculty);

            databaseEntities.SaveChanges();
        }
    }
}
