﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RecordCollection.DataAccess;

#nullable disable

namespace RecordCollection.Migrations
{
    [DbContext(typeof(RecordCollectionContext))]
    [Migration("20230718200824_AddSongModel")]
    partial class AddSongModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RecordCollection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("artist");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("release_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_albums");

                    b.ToTable("albums", (string)null);
                });

            modelBuilder.Entity("RecordCollection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("integer")
                        .HasColumnName("album_id");

                    b.Property<int>("LengthInSeconds")
                        .HasColumnType("integer")
                        .HasColumnName("length_in_seconds");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_songs");

                    b.HasIndex("AlbumId")
                        .HasDatabaseName("ix_songs_album_id");

                    b.ToTable("songs", (string)null);
                });

            modelBuilder.Entity("RecordCollection.Models.Song", b =>
                {
                    b.HasOne("RecordCollection.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_songs_albums_album_id");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("RecordCollection.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
