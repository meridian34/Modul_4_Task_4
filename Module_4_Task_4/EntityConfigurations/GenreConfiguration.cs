using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul_4_Task_4.Entities;

namespace Modul_4_Task_4.EntityConfigurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(g => g.Id);
            builder.Property(g => g.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(g => g.Title).HasColumnName("Title").HasMaxLength(50).IsRequired();
        }
    }
}
