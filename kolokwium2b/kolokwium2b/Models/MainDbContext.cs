using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MainDbContext()
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicans { get; set; }
        public DbSet<Musician_Track> Musican_Tracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Track> Tracks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Musician_Track>(d => d.HasKey(e => new { e.IdTrack, e.IdMusician }));

            modelBuilder.Entity<Album>(d => d.HasData(new Album { IdAlbum = 1, AlbumName = "AlbumName1", PublishDate = DateTime.Now, IdMusicLabel = 1}));
            modelBuilder.Entity<Album>(d => d.HasData(new Album { IdAlbum = 2, AlbumName = "AlbumName2", PublishDate = DateTime.Now, IdMusicLabel = 2}));
            modelBuilder.Entity<Musician>(d => d.HasData(new Musician { IdMusician = 1, FirstName = "Jan", LastName = "Kowalski", Nickname = "nickname1"}));
            modelBuilder.Entity<Musician>(d => d.HasData(new Musician { IdMusician = 2, FirstName = "Jan", LastName = "Nowak", Nickname = "nickname2"}));
            modelBuilder.Entity<Track>(d => d.HasData(new Track {IdTrack = 1, TrackName = "trackname1", Duration = 3.40F, IdMusicAlbum = 1}));
            modelBuilder.Entity<Track>(d => d.HasData(new Track { IdTrack = 2, TrackName = "trackname2", Duration = 6.40F, IdMusicAlbum = 2}));
            modelBuilder.Entity<Musician_Track>(d => d.HasData(new Musician_Track {IdTrack = 1, IdMusician = 1}));
            modelBuilder.Entity<Musician_Track>(d => d.HasData(new Musician_Track {IdTrack = 2, IdMusician = 2}));
            modelBuilder.Entity<MusicLabel>(d => d.HasData(new MusicLabel {IdMusicLabel = 1, Name = "TestName1"}));
            modelBuilder.Entity<MusicLabel>(d => d.HasData(new MusicLabel { IdMusicLabel = 2, Name = "TestName2"}));
        }
    }
}
