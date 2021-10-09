﻿// <auto-generated />
using EF_C_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_C_.Migrations
{
    [DbContext(typeof(School_DbContext))]
    partial class School_DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_C_.Students", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Classroom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lesson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListAverageScore")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<double>("ScoreAverage")
                        .HasColumnType("float");

                    b.Property<double>("ScoreChemical")
                        .HasColumnType("float");

                    b.Property<double>("ScoreMath")
                        .HasColumnType("float");

                    b.Property<double>("ScorePhysics")
                        .HasColumnType("float");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentCode")
                        .HasColumnType("int")
                        .HasColumnName("Students Code");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentCode")
                        .IsUnique();

                    b.HasIndex("TeacherID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_C_.Teacher", b =>
                {
                    b.Property<int>("CodeGv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Name Class");

                    b.Property<int>("NumberOfClass")
                        .HasColumnType("int")
                        .HasColumnName("Number of Class");

                    b.HasKey("CodeGv");

                    b.HasIndex("ClassRoom")
                        .IsUnique();

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EF_C_.Students", b =>
                {
                    b.HasOne("EF_C_.Teacher", "IDTeacher")
                        .WithMany("students")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDTeacher");
                });

            modelBuilder.Entity("EF_C_.Teacher", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
