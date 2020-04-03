﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParks.Models;

namespace NationalParks.Migrations
{
    [DbContext(typeof(NationalParksContext))]
    partial class NationalParksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Campgrounds");

                    b.Property<string>("City");

                    b.Property<int>("ClimbingRoutes");

                    b.Property<string>("Description");

                    b.Property<int>("GeneralStores");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");
                });
#pragma warning restore 612, 618
        }
    }
}
