﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rasa_nlu_db_storage.Data;

namespace rasa_nlu_db_storage.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190409235622_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("rasa_nlu_storage.Models.CommonExample", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intent");

                    b.Property<int?>("RasaNLUDataId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("RasaNLUDataId");

                    b.ToTable("CommonExamples");
                });

            modelBuilder.Entity("rasa_nlu_storage.Models.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommonExampleId");

                    b.Property<int>("End");

                    b.Property<string>("EntityName");

                    b.Property<int>("Start");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CommonExampleId");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("rasa_nlu_storage.Models.NluModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("NluModel");
                });

            modelBuilder.Entity("rasa_nlu_storage.Models.RasaNLUData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NluModelId");

                    b.HasKey("Id");

                    b.HasIndex("NluModelId")
                        .IsUnique();

                    b.ToTable("RasaNLUDatas");
                });

            modelBuilder.Entity("rasa_nlu_storage.Models.CommonExample", b =>
                {
                    b.HasOne("rasa_nlu_storage.Models.RasaNLUData", "RasaNLUData")
                        .WithMany("CommonExamples")
                        .HasForeignKey("RasaNLUDataId");
                });

            modelBuilder.Entity("rasa_nlu_storage.Models.Entity", b =>
                {
                    b.HasOne("rasa_nlu_storage.Models.CommonExample", "CommonExample")
                        .WithMany("Entities")
                        .HasForeignKey("CommonExampleId");
                });

            modelBuilder.Entity("rasa_nlu_storage.Models.RasaNLUData", b =>
                {
                    b.HasOne("rasa_nlu_storage.Models.NluModel")
                        .WithOne("RasaNLUData")
                        .HasForeignKey("rasa_nlu_storage.Models.RasaNLUData", "NluModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
