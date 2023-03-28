using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSpaceFlight.Migrations
{
    public partial class NewsSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ClickedNews",
                table: "NewsArticles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiscussionSaved",
                table: "DiscussionTopics",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClickedNews",
                table: "NewsArticles");

            migrationBuilder.DropColumn(
                name: "DiscussionSaved",
                table: "DiscussionTopics");
        }
    }
}
