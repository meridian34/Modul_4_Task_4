using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul_4_Task_4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_4_Task_4.EntityConfigurations
{
    class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(a => a.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");
            builder.Property(a => a.Email).HasColumnName("Email").HasMaxLength(50).IsRequired(false);
            builder.Property(a => a.InstagramUrl).HasColumnName("InstagramUrl").HasMaxLength(50).IsRequired(false);
            builder.Property(a => a.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(a => a.Phone).HasColumnName("Phone").HasMaxLength(15).IsRequired(false);

            builder.HasMany(a => a.Songs)
                .WithMany(s => s.Artists)
                .UsingEntity<Dictionary<string, object>>(
                "ArtistSong",
                sa => sa
                .HasOne<Song>()
                .WithMany()
                .HasForeignKey("SongId"),
                sa => sa
                .HasOne<Artist>()
                .WithMany()
                .HasForeignKey("ArtistId"));
        }
    }
}
