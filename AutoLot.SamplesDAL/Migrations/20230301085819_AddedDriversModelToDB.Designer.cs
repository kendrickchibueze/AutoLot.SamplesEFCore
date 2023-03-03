﻿// <auto-generated />
using System;
using AutoLot.SamplesDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoLot.SamplesDAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230301085819_AddedDriversModelToDB")]
    partial class AddedDriversModelToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Radio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("HasSubWoofers")
                        .HasColumnType("bit");

                    b.Property<bool>("HasTweeters")
                        .HasColumnType("bit");

                    b.Property<string>("RadioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Radios");
                });

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Car", b =>
                {
                    b.HasOne("AutoLot.SamplesDAL.Entities.Make", "MakeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MakeNavigation");
                });

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Radio", b =>
                {
                    b.HasOne("AutoLot.SamplesDAL.Entities.Car", "CarNavigation")
                        .WithOne("RadioNavigation")
                        .HasForeignKey("AutoLot.SamplesDAL.Entities.Radio", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarNavigation");
                });

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Car", b =>
                {
                    b.Navigation("RadioNavigation")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoLot.SamplesDAL.Entities.Make", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}