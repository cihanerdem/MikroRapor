using Entities.Concrate.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrate.EntityFrameWork.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categorys", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .HasColumnName("cat_Code")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(x => x.Name)
                .HasColumnName("cat_Name")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.Description)
                .HasColumnName("cat_Description")
                .HasMaxLength(100);
                
           
        }
    }
}
