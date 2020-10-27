using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RickLocalization.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimension",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrowsingHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DimensionFromId = table.Column<int>(nullable: false),
                    DimensionToId = table.Column<int>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrowsingHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrowsingHistory_Dimension_DimensionFromId",
                        column: x => x.DimensionFromId,
                        principalTable: "Dimension",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BrowsingHistory_Dimension_DimensionToId",
                        column: x => x.DimensionToId,
                        principalTable: "Dimension",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Dimension",
                columns: new[] { "Id", "CreateAt", "Description", "Image", "Name" },
                values: new object[] { 1, new DateTime(2020, 10, 26, 3, 17, 12, 20, DateTimeKind.Local).AddTicks(1285), "A Dimensão 35-C é um mundo muito colorido, cheio de um céu amarelo e criaturas bizarras e de aparência estranha. Vários planetas, um que lembra muito Saturno, parecem estar muito próximos da Terra desta dimensão, como são claramente visíveis durante o dia.", "", "35-C" });

            migrationBuilder.InsertData(
                table: "Dimension",
                columns: new[] { "Id", "CreateAt", "Description", "Image", "Name" },
                values: new object[] { 2, new DateTime(2020, 10, 26, 3, 17, 12, 21, DateTimeKind.Local).AddTicks(2515), "A dimensão C-137 é um dos muitos universos no multiverso e no universo onde os Rick e Morty são frequentemente identificados como provenientes. Dado que Rick não lista seu genro adotivo Jerry como originário da mesma dimensão que ele, a dimensão C-137 é o universo em que a Terra foi invadida por Cronenbergs em \"Rick Potion # 9\".", "", "C-137" });

            migrationBuilder.InsertData(
                table: "Dimension",
                columns: new[] { "Id", "CreateAt", "Description", "Image", "Name" },
                values: new object[] { 3, new DateTime(2020, 10, 26, 3, 17, 12, 21, DateTimeKind.Local).AddTicks(2546), "A dimensão C-132 é um dos muitos universos no multiverso e foi o universo em que Rick e Morty dos dois primeiros volumes da série de quadrinhos Rick e Morty foram considerados, que é separado da corrente principal de Rick e Morty , que é da Dimensão C-137 . A série mudaria o foco para Rick e Morty da Dimensão C-137 após a Edição # 10, com o destino da Dimensão C-132 sendo revelado entre as Questões # 12-14.", "", "C-132" });

            migrationBuilder.CreateIndex(
                name: "IX_BrowsingHistory_DimensionFromId",
                table: "BrowsingHistory",
                column: "DimensionFromId");

            migrationBuilder.CreateIndex(
                name: "IX_BrowsingHistory_DimensionToId",
                table: "BrowsingHistory",
                column: "DimensionToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrowsingHistory");

            migrationBuilder.DropTable(
                name: "Dimension");
        }
    }
}
