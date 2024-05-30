using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace EgyTablaDB.Migrations
{
    /// <inheritdoc />
    public partial class CreateStuddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentID2 = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true),
                    FName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MotherFName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MotherLName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BirthPlace = table.Column<string>(type: "longtext", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ShowData = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
