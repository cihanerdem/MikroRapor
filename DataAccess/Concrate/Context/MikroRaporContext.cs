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
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
