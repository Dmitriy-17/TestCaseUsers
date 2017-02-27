using System;
using System.Data.Entity;


namespace TestCaseUsers.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DBConnection") { }
        public DbSet<User> Users { get; set; }
    }
}