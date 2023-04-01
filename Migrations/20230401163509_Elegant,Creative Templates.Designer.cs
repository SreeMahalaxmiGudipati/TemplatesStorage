﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TemplatesStorage.Data;

#nullable disable

namespace TemplatesStorage.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230401163509_Elegant,Creative Templates")]
    partial class ElegantCreativeTemplates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TemplatesStorage.Models.CreativeTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("OriginalTemplates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Templates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CreativeTabel");
                });

            modelBuilder.Entity("TemplatesStorage.Models.ElegantTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("OriginalTemplates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Templates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ElegantTabel");
                });

            modelBuilder.Entity("TemplatesStorage.Models.FriendlyTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("OriginalTemplates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Templates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FriendlyTabel");
                });

            modelBuilder.Entity("TemplatesStorage.Models.ModernTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("OriginalTemplates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Templates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ModernTabel");
                });

            modelBuilder.Entity("TemplatesStorage.Models.ProfessionalTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("OriginalTemplates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Templates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProfessionalTabel");
                });

            modelBuilder.Entity("TemplatesStorage.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("OriginalTemplates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Templates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Templatestable");
                });
#pragma warning restore 612, 618
        }
    }
}
