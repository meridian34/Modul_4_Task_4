using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul_4_Task_4.Entities;

namespace Modul_4_Task_4.EntityConfigurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(s => s.Duration).HasColumnName("Duration").HasColumnType("time").IsRequired();
            builder.Property(s => s.RelesedDate).HasColumnName("RelesedDate").HasColumnType("date");
            builder.Property(s => s.Title).HasColumnName("Title").HasMaxLength(50).IsRequired();

            builder.HasOne(s => s.Genre)
                .WithMany(g => g.Songs)
                .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
