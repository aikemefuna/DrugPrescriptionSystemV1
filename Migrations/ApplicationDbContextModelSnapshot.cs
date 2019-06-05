﻿// <auto-generated />
using System;
using DrugPrescriptionSystemVersion1.DbContextClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrugPrescriptionSystemVersion1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrugPrescriptionSystemVersion1.DbModels.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DrugPrescriptionSystemVersion1.DbModels.MedicalSpecialist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("MedicalSpecialists");
                });

            modelBuilder.Entity("DrugPrescriptionSystemVersion1.DbModels.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ailment")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Dosage")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int?>("MedicalSpecialistId");

                    b.Property<string>("Medication")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MedicalSpecialistId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DrugPrescriptionSystemVersion1.DbModels.MedicalSpecialist", b =>
                {
                    b.HasOne("DrugPrescriptionSystemVersion1.DbModels.Department", "Department")
                        .WithMany("MedicalSpecialists")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("DrugPrescriptionSystemVersion1.DbModels.Patient", b =>
                {
                    b.HasOne("DrugPrescriptionSystemVersion1.DbModels.MedicalSpecialist", "MedicalSpecialist")
                        .WithMany("Patients")
                        .HasForeignKey("MedicalSpecialistId");
                });
#pragma warning restore 612, 618
        }
    }
}
