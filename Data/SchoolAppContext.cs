using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolApp.Data
{
    public class SchoolAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SchoolAppContext() : base("name=SchoolAppContext")
        {
        }

        public System.Data.Entity.DbSet<SchoolApp.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<SchoolApp.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<SchoolApp.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<SchoolApp.Models.Role> Roles { get; set; }

    }

}
