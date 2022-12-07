using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace graphql_api.Migrations
{
    public partial class InitialCreate : Migration
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
                values: new object[] { new Guid("29818ee9-5e10-4b89-84ff-0b680562aa6c"), 2021, "S90" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("5678e537-dc28-41a8-a9c3-affb412a7d78"), 2018, "V60" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ModelYear", "Name" },
                values: new object[] { new Guid("80e1c416-16d4-4184-9e61-4a4ed37ee531"), 2020, "XC90" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "PaintId", "RimId", "TyreId" },
                values: new object[] { new Guid("2c63f40d-cc3c-478f-9bd9-5f2b8c1dd056"), new Guid("80e1c416-16d4-4184-9e61-4a4ed37ee531"), new Guid("fb21d80f-4abb-4204-bb1f-c7eed67b6891"), new Guid("675a34de-3ced-4bb9-ad56-8dcca1726f64"), new Guid("28356cba-5e0a-4a80-b7e3-bcda3832a8ac") });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "PaintId", "RimId", "TyreId" },
                values: new object[] { new Guid("d8c1ce85-abfe-4cf1-816a-067812fad36e"), new Guid("29818ee9-5e10-4b89-84ff-0b680562aa6c"), new Guid("2b45123f-4a91-4b0d-9de1-4e397826aa3f"), new Guid("4d0a8e9d-0e70-456d-bcbe-02498c273606"), new Guid("f24a6e6a-d7b5-410c-81d3-110410b1c654") });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "PaintId", "RimId", "TyreId" },
                values: new object[] { new Guid("dc6e6363-30d4-4d5e-83ea-4d7ef8cb462a"), new Guid("5678e537-dc28-41a8-a9c3-affb412a7d78"), new Guid("fb21d80f-4abb-4204-bb1f-c7eed67b6891"), new Guid("4d0a8e9d-0e70-456d-bcbe-02498c273606"), new Guid("28356cba-5e0a-4a80-b7e3-bcda3832a8ac") });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("2b45123f-4a91-4b0d-9de1-4e397826aa3f"), "Space Black", 1 });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "PaintType" },
                values: new object[] { new Guid("fb21d80f-4abb-4204-bb1f-c7eed67b6891"), "Midnight Blue", 0 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("4d0a8e9d-0e70-456d-bcbe-02498c273606"), "Occult", 19 });

            migrationBuilder.InsertData(
                table: "Rims",
                columns: new[] { "Id", "Name", "Size" },
                values: new object[] { new Guid("675a34de-3ced-4bb9-ad56-8dcca1726f64"), "Dragmaster", 18 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("28356cba-5e0a-4a80-b7e3-bcda3832a8ac"), "Michelin", 0 });

            migrationBuilder.InsertData(
                table: "Tyres",
                columns: new[] { "Id", "Manufacturer", "SeasonType" },
                values: new object[] { new Guid("f24a6e6a-d7b5-410c-81d3-110410b1c654"), "Continental", 2 });
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
