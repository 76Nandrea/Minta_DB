using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EgyTablaDB.Migrations
{
    /// <inheritdoc />
    public partial class NEWOM2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentID2",
                table: "Students",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentID2",
                table: "Students");
        }
    }
}
