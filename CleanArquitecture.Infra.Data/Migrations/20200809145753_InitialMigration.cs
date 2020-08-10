using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArquitecture.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id_Carro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id_Carro);
                });

            migrationBuilder.CreateTable(
                name: "Choferes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Licencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choferes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxistas",
                columns: table => new
                {
                    DateTakeCarro = table.Column<DateTime>(nullable: false),
                    CarroId_Carro = table.Column<int>(nullable: true),
                    ChoferId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxistas", x => x.DateTakeCarro);
                    table.ForeignKey(
                        name: "FK_Taxistas_Carros_CarroId_Carro",
                        column: x => x.CarroId_Carro,
                        principalTable: "Carros",
                        principalColumn: "Id_Carro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Taxistas_Choferes_ChoferId",
                        column: x => x.ChoferId,
                        principalTable: "Choferes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Taxistas_CarroId_Carro",
                table: "Taxistas",
                column: "CarroId_Carro");

            migrationBuilder.CreateIndex(
                name: "IX_Taxistas_ChoferId",
                table: "Taxistas",
                column: "ChoferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Taxistas");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Choferes");
        }
    }
}
