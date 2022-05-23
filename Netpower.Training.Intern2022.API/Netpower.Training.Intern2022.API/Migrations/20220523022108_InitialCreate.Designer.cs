﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netpower.Training.Intern2022.API.Repositories.Context;

namespace Netpower.Training.Intern2022.API.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220523022108_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Position", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Profile", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PositionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("PositionID");

                    b.HasIndex("UserID")
                        .IsUnique()
                        .HasFilter("[UserID] IS NOT NULL");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("UserName", "Email")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Position", b =>
                {
                    b.HasOne("Netpower.Training.Intern2022.API.Entities.Department", null)
                        .WithMany("Positions")
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Profile", b =>
                {
                    b.HasOne("Netpower.Training.Intern2022.API.Entities.Position", null)
                        .WithMany("Profile")
                        .HasForeignKey("PositionID");

                    b.HasOne("Netpower.Training.Intern2022.API.Entities.User", null)
                        .WithOne("Profile")
                        .HasForeignKey("Netpower.Training.Intern2022.API.Entities.Profile", "UserID");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Department", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.Position", b =>
                {
                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Netpower.Training.Intern2022.API.Entities.User", b =>
                {
                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
