using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRaider.Migrations
{
    public partial class ChangeDatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublishDate",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Games",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
