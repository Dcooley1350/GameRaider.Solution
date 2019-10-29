using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRaider.Migrations
{
    public partial class ReviewClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Raiding",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Raiding", "ReleaseDate", "Studio", "Title" },
                values: new object[,]
                {
                    { 1, 5, "2011", "Bethesda", "Skyrim" },
                    { 2, 5, "2018", "Rockstar", "Red Dead Redemtion 2" },
                    { 3, 2, "2019", "id Software", "Wolfenstein Youngblood" },
                    { 4, 4, "2015", "FromSoftware", "Bloodborne" },
                    { 5, 3, "2013", "Ghost Games", "Need for Speed Rivals" },
                    { 6, 1, "2002", "Nintendo", "Mario Sunshine" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "GameId", "PublishDate", "Raiding", "ReviewAuthor", "ReviewText" },
                values: new object[] { 2, 1, "February 26, 2015", 2, "RunDMC123", "It is the incapable younger brother of Morrowind, but nonetheless I played it" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "GameId", "PublishDate", "Raiding", "ReviewAuthor", "ReviewText" },
                values: new object[] { 1, 2, "October 26, 2019", 5, "BeffJezos666", "The worlding building in this game is on a whole new level, bro. It is so big, so detailed, and I get to be a cowboy and ride my horse, Whitneigh Horsten, all over town" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "GameId", "PublishDate", "Raiding", "ReviewAuthor", "ReviewText" },
                values: new object[] { 3, 3, "May 1, 2002", 2, "TaylorLautner420", "This game sucked bro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Raiding",
                table: "Reviews");
        }
    }
}
