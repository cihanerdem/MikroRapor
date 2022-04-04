using Entities.Concrate.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrate.EntityFrameWork.Mapping
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .HasColumnName("dep_Code")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(x => x.Name)
              .HasColumnName("dep_Name")
              .HasMaxLength(50)
              .IsRequired();
            builder.Property(x => x.Description)
              .HasColumnName("dep_Description")
              .HasMaxLength(100);
            builder.HasData(new Department {  CreateUser=1,CreateDate=DateTime.Now,Code="DP-001",Name="Bilgi İşlem",Description="Bilgi İşlem Departmanı",Id=1 },
                            new Department { CreateUser = 1, CreateDate = DateTime.Now, Code = "DP-002", Name = "Yönetim", Description = "Yönetim Kadrosunun Bulunduğu idari Departman", Id = 2 });
             

        }
    }
}
