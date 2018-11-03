﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using VolunteerX.Data;
using VolunteerX.Models;

namespace VolunteerX.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VolunteerX.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Rating");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("VolunteerX.Models.CriteriaOfVolunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<int>("Gender");

                    b.Property<int>("Rating");

                    b.Property<int?>("SkillsOfVolunteerId");

                    b.HasKey("Id");

                    b.HasIndex("SkillsOfVolunteerId");

                    b.ToTable("CriteriaOfVolunteers");
                });

            modelBuilder.Entity("VolunteerX.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfVolunteers");

                    b.Property<string>("Description");

                    b.Property<int>("MaxOfVolunteers");

                    b.Property<string>("Name");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("VolunteerX.Models.InProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("NameOfProject");

                    b.Property<int?>("VolunteerId");

                    b.HasKey("Id");

                    b.HasIndex("VolunteerId");

                    b.ToTable("InProjects");
                });

            modelBuilder.Entity("VolunteerX.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("GroupId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("VolunteerX.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CountOfVolunteers");

                    b.Property<int?>("CriteriaOfVolunteerId");

                    b.Property<DateTime>("DateOfEndProject");

                    b.Property<DateTime>("DateOfStartProject");

                    b.Property<string>("Description");

                    b.Property<string>("LocationOfProject");

                    b.Property<string>("Name");

                    b.Property<int?>("PromotionsId");

                    b.Property<string>("SectionOfProject");

                    b.Property<int>("State");

                    b.Property<string>("TypeOfProject");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CriteriaOfVolunteerId");

                    b.HasIndex("PromotionsId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("VolunteerX.Models.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("VolunteerX.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("ProjectId");

                    b.Property<string>("Text");

                    b.Property<int?>("VolunteerId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("VolunteerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("VolunteerX.Models.SectionOfProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SectionOfProjects");
                });

            modelBuilder.Entity("VolunteerX.Models.SkillsOfVolunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanProvideAID");

                    b.HasKey("Id");

                    b.ToTable("SkillsOfVolunteers");
                });

            modelBuilder.Entity("VolunteerX.Models.TaskOfVolunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("GroupId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("TaskOfVolunteers");
                });

            modelBuilder.Entity("VolunteerX.Models.TypeOfProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TypeOfProjects");
                });

            modelBuilder.Entity("VolunteerX.Models.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ChatId");

                    b.Property<int?>("CurrentOfProjectId");

                    b.Property<DateTime>("DateOfBirthday");

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<int?>("GroupId");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Rating");

                    b.Property<string>("Remark");

                    b.Property<string>("Resume");

                    b.Property<int?>("SkillsOfVolunteerId");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("CurrentOfProjectId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SkillsOfVolunteerId");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("VolunteerX.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VolunteerX.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VolunteerX.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VolunteerX.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VolunteerX.Models.CriteriaOfVolunteer", b =>
                {
                    b.HasOne("VolunteerX.Models.SkillsOfVolunteer", "SkillsOfVolunteer")
                        .WithMany()
                        .HasForeignKey("SkillsOfVolunteerId");
                });

            modelBuilder.Entity("VolunteerX.Models.InProject", b =>
                {
                    b.HasOne("VolunteerX.Models.Volunteer")
                        .WithMany("HistoryOfProjects")
                        .HasForeignKey("VolunteerId");
                });

            modelBuilder.Entity("VolunteerX.Models.Message", b =>
                {
                    b.HasOne("VolunteerX.Models.Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("VolunteerX.Models.Project", b =>
                {
                    b.HasOne("VolunteerX.Models.ApplicationUser")
                        .WithMany("Projects")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("VolunteerX.Models.CriteriaOfVolunteer", "CriteriaOfVolunteer")
                        .WithMany()
                        .HasForeignKey("CriteriaOfVolunteerId");

                    b.HasOne("VolunteerX.Models.Promotion", "Promotions")
                        .WithMany()
                        .HasForeignKey("PromotionsId");
                });

            modelBuilder.Entity("VolunteerX.Models.Review", b =>
                {
                    b.HasOne("VolunteerX.Models.Project")
                        .WithMany("Reviews")
                        .HasForeignKey("ProjectId");

                    b.HasOne("VolunteerX.Models.Volunteer")
                        .WithMany("Reviews")
                        .HasForeignKey("VolunteerId");
                });

            modelBuilder.Entity("VolunteerX.Models.Volunteer", b =>
                {
                    b.HasOne("VolunteerX.Models.Project", "CurrentOfProject")
                        .WithMany("InProject")
                        .HasForeignKey("CurrentOfProjectId");

                    b.HasOne("VolunteerX.Models.Group")
                        .WithMany("Volunteers")
                        .HasForeignKey("GroupId");

                    b.HasOne("VolunteerX.Models.SkillsOfVolunteer", "SkillsOfVolunteer")
                        .WithMany()
                        .HasForeignKey("SkillsOfVolunteerId");
                });
#pragma warning restore 612, 618
        }
    }
}
