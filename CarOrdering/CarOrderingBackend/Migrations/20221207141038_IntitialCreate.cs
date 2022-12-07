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
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CarModelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaintId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RimId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TyreId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("2fb81c08-2593-42c3-b3c1-cfc9ebf38fd7"), 2021, "S90" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("5d1d2b66-9d55-4074-8712-6caad55d569a"), 2018, "V60" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("6cf296b8-66bd-419a-8532-ecda364e42fa"), 2020, "XC90" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "PaintId", "RimId", "TyreId" },
                values: new object[] { new Guid("69b9217f-1dbd-4dc9-8a48-90ab90e9f4a1"), new Guid("2fb81c08-2593-42c3-b3c1-cfc9ebf38fd7"), new Guid("567344be-1cb1-4dd2-8001-030339b4f705"), new Guid("15a31af7-9d0c-4bee-a377-5b38fe5d9b38"), new Guid("22c54800-560c-4ee7-a8c3-6026ab684d65") });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "PaintId", "RimId", "TyreId" },
                values: new object[] { new Guid("dfad21e4-c1d6-44ac-9117-a91689e22ddc"), new Guid("6cf296b8-66bd-419a-8532-ecda364e42fa"), new Guid("544a8644-3572-4daf-a615-174843429997"), new Guid("f5ab9bbd-5d3d-4de0-9c8a-179b44e281e7"), new Guid("067de25c-5842-4d57-92a5-e26ab856bbd9") });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "PaintId", "RimId", "TyreId" },
                values: new object[] { new Guid("ea8f91d6-6d8a-463e-9dd4-7213dc70083b"), new Guid("5d1d2b66-9d55-4074-8712-6caad55d569a"), new Guid("544a8644-3572-4daf-a615-174843429997"), new Guid("15a31af7-9d0c-4bee-a377-5b38fe5d9b38"), new Guid("067de25c-5842-4d57-92a5-e26ab856bbd9") });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("544a8644-3572-4daf-a615-174843429997"), "Midnight Blue", 0 });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("567344be-1cb1-4dd2-8001-030339b4f705"), "Space Black", 1 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("15a31af7-9d0c-4bee-a377-5b38fe5d9b38"), "Occult", 19 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("f5ab9bbd-5d3d-4de0-9c8a-179b44e281e7"), "Dragmaster", 18 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("067de25c-5842-4d57-92a5-e26ab856bbd9"), "Michelin", 0 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("22c54800-560c-4ee7-a8c3-6026ab684d65"), "Continental", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Paints");

            migrationBuilder.DropTable(
                name: "Rims");

            migrationBuilder.DropTable(
                name: "Tyres");
        }
    }
}
