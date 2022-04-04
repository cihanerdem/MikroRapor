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
    public class ReportSourceMap : IEntityTypeConfiguration<ReportSource>
    {
        public void Configure(EntityTypeBuilder<ReportSource> builder)
        {
            builder.ToTable("ReportSources", @"dbo");
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.MenuId)
                .HasColumnName("rep_MenuId")
                .IsRequired();
            builder.Property(x => x.ReportCode)
                .HasColumnName("rep_ReportCode")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(x => x.ReportName)
                .HasColumnName("rep_ReportName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.ReportNumber)
                .HasColumnName("rep_ReportNumber")
                .IsRequired();
            builder.Property(x => x.SourceCode)
                .HasColumnName("rep_SourceCode")
                .IsRequired();
            builder.Property(x => x.UserToAccess)
                .HasColumnName("rep_UserToAccess")
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(x => x.CategoryId)
                .HasColumnName("rep_CategoryId")
                .IsRequired();

        }
    }
}
