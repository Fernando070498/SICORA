using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SICORA.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Desc_juego = table.Column<string>(nullable: true),
                    Img_juego = table.Column<string>(nullable: true),
                    Nom_juego = table.Column<string>(nullable: true),
                    pre_juego = table.Column<string>(nullable: true),
                    trailer_juego = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Perifericos",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Desc_perifericos = table.Column<string>(nullable: true),
                    Img_perifericos = table.Column<string>(nullable: true),
                    Nom_perifericos = table.Column<string>(nullable: true),
                    pre_perifericos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perifericos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Programas",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Desc_programa = table.Column<string>(nullable: true),
                    Img_programa = table.Column<string>(nullable: true),
                    Nom_programa = table.Column<string>(nullable: true),
                    pre_programa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prueba_bd",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Desc_juego = table.Column<string>(nullable: true),
                    Imagen_juego = table.Column<string>(nullable: true),
                    Nom_juego = table.Column<string>(nullable: true),
                    Pre_juego = table.Column<string>(nullable: true),
                    Trailer_juego = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prueba_bd", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Perifericos");

            migrationBuilder.DropTable(
                name: "Programas");

            migrationBuilder.DropTable(
                name: "Prueba_bd");
        }
    }
}
