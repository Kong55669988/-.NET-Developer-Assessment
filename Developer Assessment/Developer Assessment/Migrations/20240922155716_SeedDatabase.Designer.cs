﻿// <auto-generated />
using System;
using Developer_Assessment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Developer_Assessment.Migrations
{
    [DbContext(typeof(CDNDbContext))]
    [Migration("20240922155716_SeedDatabase")]
    partial class SeedDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Developer_Assessment.Models.Entity.Freelancers.Freelancer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hobby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillSets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Freelancers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6086),
                            Hobby = "Photography",
                            Mail = "john.doe@example.com",
                            ModifiedTime = new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6088),
                            PhoneNumber = "123-456-7890",
                            SkillSets = "C#, SQL, ASP.NET",
                            Username = "John Doe",
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6090),
                            Hobby = "Cycling",
                            Mail = "jane.smith@example.com",
                            ModifiedTime = new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6091),
                            PhoneNumber = "234-567-8901",
                            SkillSets = "Java, Spring, Hibernate",
                            Username = "Jane Smith",
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6092),
                            Hobby = "Reading",
                            Mail = "michael.brown@example.com",
                            ModifiedTime = new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6093),
                            PhoneNumber = "345-678-9012",
                            SkillSets = "Python, Django, AI",
                            Username = "Michael Brown",
                            isActive = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
