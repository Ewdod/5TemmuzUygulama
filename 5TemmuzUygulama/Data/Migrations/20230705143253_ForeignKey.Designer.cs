﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _5TemmuzUygulama.Data;

#nullable disable

namespace _5TemmuzUygulama.Data.Migrations
{
    [DbContext(typeof(DonemDbContext))]
    [Migration("20230705143253_ForeignKey")]
    partial class ForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_5TemmuzUygulama.Data.Donem", b =>
                {
                    b.Property<int>("SemesterNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemesterNo"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("ParaBaglantisi")
                        .HasColumnType("int");

                    b.Property<string>("SemesterCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Tur")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SemesterNo");

                    b.HasIndex("ParaBaglantisi")
                        .IsUnique();

                    b.HasIndex("Tur")
                        .IsUnique();

                    b.ToTable("Semesters", (string)null);
                });

            modelBuilder.Entity("_5TemmuzUygulama.Data.TotalMoney", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TotalMoney");
                });

            modelBuilder.Entity("_5TemmuzUygulama.Data.Donem", b =>
                {
                    b.HasOne("_5TemmuzUygulama.Data.TotalMoney", "TotalMoney")
                        .WithOne("Donem")
                        .HasForeignKey("_5TemmuzUygulama.Data.Donem", "ParaBaglantisi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TotalMoney");
                });

            modelBuilder.Entity("_5TemmuzUygulama.Data.TotalMoney", b =>
                {
                    b.Navigation("Donem")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
