using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Employee_analytics.Models;




namespace Employee_analytics.DAL
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("Employee_analytics")
        {
        }

        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}