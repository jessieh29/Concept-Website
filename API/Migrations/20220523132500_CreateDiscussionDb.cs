using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSpaceFlight.Migrations
{
    public partial class CreateDiscussionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsArticles",
                table: "NewsArticles");

            migrationBuilder.RenameTable(
                name: "NewsArticles",
                newName: "News");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.RenameTable(
                name: "News",
                newName: "NewsArticles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsArticles",
                table: "NewsArticles",
                column: "Id");
        }
    }
}
