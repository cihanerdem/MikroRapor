using Entities.Concrate.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrate.EntityFrameWork.Mapping
{
    public class AppMenuMap : IEntityTypeConfiguration<AppMenu>
    {
        public void Configure(EntityTypeBuilder<AppMenu> builder)
        {
            builder.ToTable("AppMenus", @"dbo");
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.MenuName)
                .HasColumnName("app_MenuName")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.MenuNo)
                .HasColumnName("app_MenuNo")
                .IsRequired();
            builder.Property(x => x.Description)
                .HasColumnName("app_Description")
                .HasMaxLength(100);
            builder.Property(x => x.StaffIdToAccess)
                .HasColumnName("app_StaffIdToAccess")
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(x => x.Url)
                .HasColumnName("app_Url")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.CategoryId)
                .HasColumnName("app_CategoryId")
                .IsRequired();
            builder.Property(x => x.AssociatedMenuId)
                .HasColumnName("app_AssociatedMenuId")
                .IsRequired();
        }
    }
}
