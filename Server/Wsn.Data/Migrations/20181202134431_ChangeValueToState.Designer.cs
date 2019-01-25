﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wsn.Data;

namespace Wsn.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181202134431_ChangeValueToState")]
    partial class ChangeValueToState
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Wsn.Core.Domain.LightReading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Date");

                    b.Property<int>("DeviceId");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.ToTable("LightReadings");
                });
#pragma warning restore 612, 618
        }
    }
}
