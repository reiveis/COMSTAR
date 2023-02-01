﻿// <auto-generated />
using System;
using COMSTAR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMSTAR.Migrations
{
    [DbContext(typeof(COMSTARContext))]
    [Migration("20221204223519_comstarv2")]
    partial class comstarv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMSTAR.Models.Events", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("date");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(280)")
                        .HasMaxLength(280);

                    b.Property<byte[]>("EventImage")
                        .HasColumnType("image");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("EventTarget")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("EventId")
                        .HasName("PK__Events__7944C8108C94A8CC");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}