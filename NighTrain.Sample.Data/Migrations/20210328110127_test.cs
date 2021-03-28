using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NighTrain.Sample.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    Surname = table.Column<string>(type: "varchar(150)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 28, 14, 1, 27, 529, DateTimeKind.Local).AddTicks(3391), "Name", "Surname" },
                    { 2, new DateTime(2021, 3, 28, 14, 1, 27, 530, DateTimeKind.Local).AddTicks(1367), "Name2", "Surname2" },
                    { 3, new DateTime(2021, 3, 28, 14, 1, 27, 530, DateTimeKind.Local).AddTicks(1382), "Name3", "Surname3" },
                    { 4, new DateTime(2021, 3, 28, 14, 1, 27, 530, DateTimeKind.Local).AddTicks(1384), "Name4", "Surname4" },
                    { 5, new DateTime(2021, 3, 28, 14, 1, 27, 530, DateTimeKind.Local).AddTicks(1385), "Name5", "Surname5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
