using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizBlazor.Server.Data.Migrations
{
    public partial class addedTimeLimit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TimeLimit",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeLimit",
                table: "Questions");
        }
    }
}
