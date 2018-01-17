﻿// <auto-generated />
using DeltaXApi;
using DeltaXApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DeltaXApi.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("DeltaXApi.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("sex");

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("DeltaXApi.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Plot");

                    b.Property<string>("PosterPath");

                    b.Property<int>("ProducerID");

                    b.Property<DateTime>("ReleaseYear");

                    b.HasKey("Id");

                    b.HasIndex("ProducerID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("DeltaXApi.Models.MovieActor", b =>
                {
                    b.Property<int>("MovieID");

                    b.Property<int>("ActorID");

                    b.HasKey("MovieID", "ActorID");

                    b.HasIndex("ActorID");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("DeltaXApi.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("sex");

                    b.HasKey("Id");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("DeltaXApi.Models.Movie", b =>
                {
                    b.HasOne("DeltaXApi.Models.Producer", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DeltaXApi.Models.MovieActor", b =>
                {
                    b.HasOne("DeltaXApi.Models.Actor", "Actor")
                        .WithMany("MovieActor")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DeltaXApi.Models.Movie", "Movie")
                        .WithMany("MovieActor")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}