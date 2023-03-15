﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RosteringPractice.DbContexts;

#nullable disable

namespace RosteringPractice.Migrations
{
    [DbContext(typeof(UserInfoContext))]
    partial class UserInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.14");

            modelBuilder.Entity("RosteringPractice.Entity.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Angular"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Web API"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Python"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Machine Learning"
                        });
                });

            modelBuilder.Entity("RosteringPractice.Entity.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Vishalanilrathod@gmail.com",
                            Location = "Vadodara",
                            Name = "Vishal Rathod",
                            Password = "Vishal@123",
                            SkillId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "rahulparik12@gmail.com",
                            Location = "Vadodara",
                            Name = "Rahul Parik",
                            Password = "Rahul@123",
                            SkillId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "sdrathod4801@gmail.com",
                            Location = "Vadodara",
                            Name = "Shubham Rathod",
                            Password = "Shubham@123",
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("RosteringPractice.Entity.Skills", b =>
                {
                    b.HasOne("RosteringPractice.Entity.Users", null)
                        .WithMany("skills")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("RosteringPractice.Entity.Users", b =>
                {
                    b.HasOne("RosteringPractice.Entity.Skills", "Skills")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("RosteringPractice.Entity.Users", b =>
                {
                    b.Navigation("skills");
                });
#pragma warning restore 612, 618
        }
    }
}
