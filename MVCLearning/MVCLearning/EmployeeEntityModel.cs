namespace MVCLearning
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using MVCLearning.Models;
    public class EmployeeEntityModel : DbContext
    {
        // Your context has been configured to use a 'EmployeeEntityModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVCLearning.EmployeeEntityModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmployeeEntityModel' 
        // connection string in the application configuration file.
        public EmployeeEntityModel():base("EmployeeEntityModel")    
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmployeeEntityModel, MVCLearning.Migrations.Configuration > ());
        }
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            
            dbModelBuilder.Entity<Employee>().ToTable("TblEmployees");
            base.OnModelCreating(dbModelBuilder);
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}