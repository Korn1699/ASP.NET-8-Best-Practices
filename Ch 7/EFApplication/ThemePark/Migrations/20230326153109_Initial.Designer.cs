﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThemePark.DataContext;

#nullable disable

namespace EFApplication.Migrations
{
    [DbContext(typeof(ThemeParkDbContext))]
    [Migration("20230326153109_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFApplication.DataContext.Models.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Attractions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocationId = 2,
                            Name = "Twirly Ride"
                        },
                        new
                        {
                            Id = 2,
                            LocationId = 5,
                            Name = "Mine car Coaster"
                        },
                        new
                        {
                            Id = 3,
                            LocationId = 3,
                            Name = "Haunted House"
                        },
                        new
                        {
                            Id = 4,
                            LocationId = 2,
                            Name = "Dragon Ride"
                        },
                        new
                        {
                            Id = 5,
                            LocationId = 1,
                            Name = "Gift Shop"
                        },
                        new
                        {
                            Id = 6,
                            LocationId = 4,
                            Name = "Space Ride"
                        },
                        new
                        {
                            Id = 7,
                            LocationId = 5,
                            Name = "Shootout at OK Corral/Lazer Tag"
                        });
                });

            modelBuilder.Entity("EFApplication.DataContext.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "General"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sci/Fi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Western"
                        });
                });

            modelBuilder.Entity("EFApplication.DataContext.Models.Attraction", b =>
                {
                    b.HasOne("EFApplication.DataContext.Models.Location", "Location")
                        .WithMany("Attractions")
                        .HasForeignKey("LocationId")
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("EFApplication.DataContext.Models.Location", b =>
                {
                    b.Navigation("Attractions");
                });
#pragma warning restore 612, 618
        }
    }
}
