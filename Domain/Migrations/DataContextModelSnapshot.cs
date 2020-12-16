﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YukonTest.Domain;

namespace YukonTest.Domain.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("YukonTest.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Leave");

                    b.Property<string>("Name");

                    b.Property<int>("SubjectID");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}