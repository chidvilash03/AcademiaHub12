﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademiaHub.Migrations
{
    [DbContext(typeof(AcademiaHubContext))]
    partial class AcademiaHubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcademiaHub.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("AcademiaHub.Models.Guardian", b =>
                {
                    b.Property<int>("GuardianID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuardianID"));

                    b.Property<string>("GuardianAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationshipWithChild")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuardianID");

                    b.ToTable("Guardians");
                });

            modelBuilder.Entity("AcademiaHub.Models.Parent", b =>
                {
                    b.Property<int>("ParentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentID"));

                    b.Property<string>("FatherAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentID");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("AcademiaHub.Models.Student", b =>
                {
                    b.Property<int>("EnrollmentNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentNo"));

                    b.Property<string>("AadharNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuardianID")
                        .HasColumnType("int");

                    b.Property<int?>("GuardianID1")
                        .HasColumnType("int");

                    b.Property<int>("HostelID")
                        .HasColumnType("int");

                    b.Property<int>("HostelerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherTongue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentID")
                        .HasColumnType("int");

                    b.Property<int?>("ParentID1")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionID")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnrollmentNo");

                    b.HasIndex("ClassID");

                    b.HasIndex("GuardianID");

                    b.HasIndex("GuardianID1");

                    b.HasIndex("HostelID");

                    b.HasIndex("HostelerID");

                    b.HasIndex("ParentID");

                    b.HasIndex("ParentID1");

                    b.HasIndex("SectionID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Hostel", b =>
                {
                    b.Property<int>("HostelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HostelID"));

                    b.Property<string>("HostelGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HostelID");

                    b.ToTable("Hostels");
                });

            modelBuilder.Entity("Hosteler", b =>
                {
                    b.Property<int>("HostelerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HostelerID"));

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnrollmentNo")
                        .HasColumnType("int");

                    b.Property<int>("HostelID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HostelerID");

                    b.HasIndex("EnrollmentNo");

                    b.HasIndex("HostelID");

                    b.ToTable("Hostelers");
                });

            modelBuilder.Entity("Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionID"));

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("AcademiaHub.Models.Student", b =>
                {
                    b.HasOne("AcademiaHub.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademiaHub.Models.Guardian", "Guardian")
                        .WithMany()
                        .HasForeignKey("GuardianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademiaHub.Models.Guardian", null)
                        .WithMany("Students")
                        .HasForeignKey("GuardianID1");

                    b.HasOne("Hostel", "Hostel")
                        .WithMany()
                        .HasForeignKey("HostelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hosteler", "Hosteler")
                        .WithMany()
                        .HasForeignKey("HostelerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademiaHub.Models.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademiaHub.Models.Parent", null)
                        .WithMany("Students")
                        .HasForeignKey("ParentID1");

                    b.HasOne("Section", "Section")
                        .WithMany("Students")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Guardian");

                    b.Navigation("Hostel");

                    b.Navigation("Hosteler");

                    b.Navigation("Parent");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("Hosteler", b =>
                {
                    b.HasOne("AcademiaHub.Models.Student", "Student")
                        .WithMany("Hostelers")
                        .HasForeignKey("EnrollmentNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hostel", "Hostel")
                        .WithMany("Hostelers")
                        .HasForeignKey("HostelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hostel");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AcademiaHub.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AcademiaHub.Models.Guardian", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AcademiaHub.Models.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AcademiaHub.Models.Student", b =>
                {
                    b.Navigation("Hostelers");
                });

            modelBuilder.Entity("Hostel", b =>
                {
                    b.Navigation("Hostelers");
                });

            modelBuilder.Entity("Section", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
