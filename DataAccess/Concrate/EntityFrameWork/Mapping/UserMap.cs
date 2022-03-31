using Entities.Concrate.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFrameWork.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName)
                .HasColumnName("usr_UserName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.FirstName)
                .HasColumnName("usr_FirstName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.LastName)
                .HasColumnName("usr_LastName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Department)
                .HasColumnName("usr_Department")
                .IsRequired();
            builder.Property(x => x.GSM)
                .HasColumnName("usr_GSM")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(x => x.Email)
            .HasColumnName("usr_Email")
            .HasMaxLength(100)
            .IsRequired();
            builder.Property(x => x.Password)
                .HasColumnName("usr_Password")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(x => x.UserRole)
                .HasColumnName("usr_UserRole")
                .IsRequired();
            builder.Property(x => x.UseDatabeses)
                .HasColumnName("usr_UseDatabases")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Token)
                .HasColumnName("usr_Token")
                .HasMaxLength(255);
            builder.Property(x => x.TokenExpireDate)
             .HasColumnName("usr_TokenExpireDate");
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);

            builder.HasData(new User
            {
                Id=1,
                CreateDate = DateTime.Now,
                FirstName = "Cihan",
                LastName = "Erdem",
                CreateUser = 1,
                Department = 1,
                Email = "cihan.erdem@goksuglobal.com.tr",
                GSM = "5359644983",
                Password = "sander1978",
                UseDatabeses = "MikroDB_V16_GG_22,MikroDB_V16_BEX_22",
                UserName = "sander78",
                UserRole = 0
            });
        }
    }
}
