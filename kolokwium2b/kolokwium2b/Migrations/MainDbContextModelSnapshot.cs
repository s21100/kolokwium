﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolokwium2b.Models;

namespace kolokwium2b.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kolokwium2b.Models.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IdMusicLabel")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlbum");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            IdAlbum = 1,
                            AlbumName = "AlbumName1",
                            IdMusicLabel = 1,
                            PublishDate = new DateTime(2022, 6, 12, 8, 43, 47, 246, DateTimeKind.Local).AddTicks(2398)
                        },
                        new
                        {
                            IdAlbum = 2,
                            AlbumName = "AlbumName2",
                            IdMusicLabel = 2,
                            PublishDate = new DateTime(2022, 6, 12, 8, 43, 47, 248, DateTimeKind.Local).AddTicks(7843)
                        });
                });

            modelBuilder.Entity("kolokwium2b.Models.MusicLabel", b =>
                {
                    b.Property<int>("IdMusicLabel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMusicLabel");

                    b.ToTable("MusicLabels");

                    b.HasData(
                        new
                        {
                            IdMusicLabel = 1,
                            Name = "TestName1"
                        },
                        new
                        {
                            IdMusicLabel = 2,
                            Name = "TestName2"
                        });
                });

            modelBuilder.Entity("kolokwium2b.Models.Musician", b =>
                {
                    b.Property<int>("IdMusician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMusician");

                    b.ToTable("Musicans");

                    b.HasData(
                        new
                        {
                            IdMusician = 1,
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Nickname = "nickname1"
                        },
                        new
                        {
                            IdMusician = 2,
                            FirstName = "Jan",
                            LastName = "Nowak",
                            Nickname = "nickname2"
                        });
                });

            modelBuilder.Entity("kolokwium2b.Models.Musician_Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .HasColumnType("int");

                    b.Property<int>("IdMusician")
                        .HasColumnType("int");

                    b.HasKey("IdTrack", "IdMusician");

                    b.ToTable("Musican_Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 1,
                            IdMusician = 1
                        },
                        new
                        {
                            IdTrack = 2,
                            IdMusician = 2
                        });
                });

            modelBuilder.Entity("kolokwium2b.Models.Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<int>("IdMusicAlbum")
                        .HasColumnType("int");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTrack");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 1,
                            Duration = 3.4f,
                            IdMusicAlbum = 1,
                            TrackName = "trackname1"
                        },
                        new
                        {
                            IdTrack = 2,
                            Duration = 6.4f,
                            IdMusicAlbum = 2,
                            TrackName = "trackname2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}