﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using SICORA.Models;
using System;

namespace SICORA.Migrations
{
    [DbContext(typeof(MvcContext))]
    [Migration("20181103223255_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("SICORA.Models.Prueba_bd", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Desc_juego");

                    b.Property<string>("Nom_juego");

                    b.Property<string>("pre_juego");

                    b.Property<string>("trailer_juego");

                    b.HasKey("ID");

                    b.ToTable("Prueba_bd");
                });
#pragma warning restore 612, 618
        }
    }
}
