using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarOrderingBackend.Migrations
{
    public partial class IntitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ModelYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    PaintType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tyres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    SeasonType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tyres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CarModelId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PaintId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RimsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TyresId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Paints_PaintId",
                        column: x => x.PaintId,
                        principalTable: "Paints",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Rims_RimsId",
                        column: x => x.RimsId,
                        principalTable: "Rims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Tyres_TyresId",
                        column: x => x.TyresId,
                        principalTable: "Tyres",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("171592d0-5034-4d9a-832a-5227b6650e7a"), 2021, "S90" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("a86aa4e4-881b-475c-96a3-db12902cfb2d"), 2018, "V60" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("db1bb43f-4dd4-4e3b-96fd-4322f89a24a4"), 2020, "XC90" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "Name", "PaintId", "RimsId", "TyresId" },
                values: new object[] { new Guid("3f8793de-1fd7-4c19-be36-36bb6ef03215"), null, "CustomCar1", null, null, null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "Name", "PaintId", "RimsId", "TyresId" },
                values: new object[] { new Guid("411eb5c4-b628-4c87-af77-a63769de382c"), null, "CustomCar3", null, null, null });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "Name", "PaintId", "RimsId", "TyresId" },
                values: new object[] { new Guid("eccadda2-77ac-4f9e-a960-42a2ff232029"), null, "CustomCar2", null, null, null });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("00d3636a-df2b-43a3-b4f4-f98d904bc6de"), "Snow White", 2 });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("3a310079-ce3a-415b-9992-29b75a76e3ba"), "Midnight Blue", 0 });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("7a2ef43a-0c57-446b-aecb-ad1b293332c3"), "Night Black", 1 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("6bbc9408-9c95-4e06-b3c9-078679fb06f9"), "Dragmaster", 18 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("883b2311-3168-455a-a54c-c97bc166fe80"), "Dream", 17 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("e872b2b8-0172-4f66-8a79-c1b7396cd4ab"), "Occult", 19 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("2e60fd51-81a2-40ae-88b7-1820a9c25ed4"), "Pirelli", 1 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("5511b992-7318-42d0-a388-4aecc3eb8d32"), "Continental", 2 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("8da92000-acfc-42e2-bbac-e9852c24fbbc"), "Michelin", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_PaintId",
                table: "Cars",
                column: "PaintId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RimsId",
                table: "Cars",
                column: "RimsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TyresId",
                table: "Cars",
                column: "TyresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Paints");

            migrationBuilder.DropTable(
                name: "Rims");

            migrationBuilder.DropTable(
                name: "Tyres");
        }
    }
}
