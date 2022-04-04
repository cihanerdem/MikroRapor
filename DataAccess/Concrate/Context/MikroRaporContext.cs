using DataAccess.Concrate.EntityFrameWork.Mapping;
using Entities.Concrate.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrate.Context
{
    public class MikroRaporContext:DbContext
    {
        public MikroRaporContext(DbContextOptions<MikroRaporContext> options):base(options)
        {

        }
        public MikroRaporContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-BP9BGS3;Initial Catalog=MikroReportDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new AppMenuMap());
            modelBuilder.ApplyConfiguration(new ReportSourceMap());

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<AppMenu> AppMenus { get; set; }
        public virtual DbSet<ReportSource> ReportSources { get; set; }
    }
}
