﻿// <auto-generated />
using System;
using AssignmentsNetcore.Repositories.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AssignmentsNetcore.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20181101232959_Changes")]
    partial class Changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("EndDate");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("ProjectComponentId");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Workload");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("ProjectComponentId");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.AssignmentRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssignmentId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("JobRoleId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("JobRoleId");

                    b.ToTable("AssignmentRole");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Changes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColumnName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("NewValue");

                    b.Property<string>("PreviousValue");

                    b.Property<string>("TableName");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssignmentId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int?>("ReviewerId");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.JobRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("JobRoleType");

                    b.Property<string>("Name");

                    b.Property<int?>("PersonId");

                    b.Property<int>("TechId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TechId");

                    b.ToTable("JobRole");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address");

                    b.Property<int>("Country");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("Mail");

                    b.Property<int>("OfficeId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Workload");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Project");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.ProjectComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("EndDate");

                    b.Property<int?>("ProjectId");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.Property<int?>("TechId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TechId");

                    b.ToTable("ProjectComponent");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Tech", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Tech");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsExternal");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

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

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.HasIndex("UserId");

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

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Commercial", b =>
                {
                    b.HasBaseType("AssignmentsNetcore.Models.Database.Project");

                    b.Property<bool>("IsTeamAugmentation");

                    b.ToTable("Commercial");

                    b.HasDiscriminator().HasValue("Commercial");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.HHII", b =>
                {
                    b.HasBaseType("AssignmentsNetcore.Models.Database.Project");


                    b.ToTable("HHII");

                    b.HasDiscriminator().HasValue("HHII");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Training", b =>
                {
                    b.HasBaseType("AssignmentsNetcore.Models.Database.Project");

                    b.Property<bool>("Individual");

                    b.Property<bool>("Remote");

                    b.ToTable("Training");

                    b.HasDiscriminator().HasValue("Training");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Assignment", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("AssignmentsNetcore.Models.Database.ProjectComponent", "ProjectComponent")
                        .WithMany("Assignments")
                        .HasForeignKey("ProjectComponentId");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.AssignmentRole", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Assignment", "Assignment")
                        .WithMany("AssignmentRoles")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("AssignmentsNetcore.Models.Database.JobRole", "JobRole")
                        .WithMany()
                        .HasForeignKey("JobRoleId");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Changes", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Feedback", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Assignment", "Assignment")
                        .WithMany("Feedbacks")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("AssignmentsNetcore.Models.Database.Person", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.JobRole", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Person")
                        .WithMany("JobRoles")
                        .HasForeignKey("PersonId");

                    b.HasOne("AssignmentsNetcore.Models.Database.Tech", "Tech")
                        .WithMany()
                        .HasForeignKey("TechId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Person", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.Project", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("AssignmentsNetcore.Models.Database.ProjectComponent", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.Project", "Project")
                        .WithMany("ProjectComponents")
                        .HasForeignKey("ProjectId");

                    b.HasOne("AssignmentsNetcore.Models.Database.Tech", "Tech")
                        .WithMany()
                        .HasForeignKey("TechId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
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
                    b.HasOne("AssignmentsNetcore.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.User")
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

                    b.HasOne("AssignmentsNetcore.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AssignmentsNetcore.Models.Database.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}