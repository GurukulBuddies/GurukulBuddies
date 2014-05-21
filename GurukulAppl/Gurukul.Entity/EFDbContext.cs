
namespace Gurukul.Entity
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using Gurukul.Entity.Domain;
    using Gurukul.Entity.Configuration;
    using System.Web;

    public partial class EFDbContext : DbContext
    {
        private readonly HttpContextBase httpContext;

        public EFDbContext(string nameOrConnectionString, HttpContextBase httpContext)
            : this(nameOrConnectionString)
        {
            this.httpContext = httpContext;
        }

        public EFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.SetInitializer<EFDbContext>(new DropCreateDatabaseIfModelChanges<EFDbContext>());
            ConnectionString = nameOrConnectionString;
        }

        public string ConnectionString { get; private set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Collage_Profile_Configuration());
            modelBuilder.Configurations.Add(new Contact_Configuration());
            modelBuilder.Configurations.Add(new Department_Configuration());
            modelBuilder.Configurations.Add(new ELibrary_Configuration());
            modelBuilder.Configurations.Add(new Employee_Configuration());
            modelBuilder.Configurations.Add(new EmployeeGrade_Configuration());
            modelBuilder.Configurations.Add(new Event_Configuration());
            modelBuilder.Configurations.Add(new Exam_Configuration());
            modelBuilder.Configurations.Add(new ExamResult_Configuration());
            modelBuilder.Configurations.Add(new ExamTimeTable_Configuration());
            modelBuilder.Configurations.Add(new NewsLetter_Configuration());
            modelBuilder.Configurations.Add(new Semester_Configuration());
            modelBuilder.Configurations.Add(new StaticData_Configuration());
            modelBuilder.Configurations.Add(new Student_Configuration());
            modelBuilder.Configurations.Add(new Subject_Configuration());
            modelBuilder.Configurations.Add(new User_Category_Configuration());
            modelBuilder.Configurations.Add(new User_Profile_Configuration());
            modelBuilder.Configurations.Add(new User_Role_Configuration());
            modelBuilder.Configurations.Add(new User_Task_Configuration());
        }

        public DbSet<Collage_Profile> Collage_Profile { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ELibrary> ELibraries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeGrade> EmployeeGrades { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<ExamTimeTable> ExamTimeTables { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<StaticData> StaticDatas { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User_Category> User_Category { get; set; }
        public DbSet<User_Profile> User_Profile { get; set; }
        public DbSet<User_Role> User_Role { get; set; }
        public DbSet<User_Task> User_Task { get; set; }

    }
}
