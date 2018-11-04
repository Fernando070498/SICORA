using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SICORA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prueba_bd",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Desc_juego = table.Column<string>(nullable: true),
                    Nom_juego = table.Column<string>(nullable: true),
                    pre_juego = table.Column<string>(nullable: true),
                    trailer_juego = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prueba_bd", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prueba_bd");
        }
    }
}
