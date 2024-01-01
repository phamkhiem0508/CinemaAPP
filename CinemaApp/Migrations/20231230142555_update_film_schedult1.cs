using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaApp.Migrations
{
    /// <inheritdoc />
    public partial class update_film_schedult1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmScheduleModels_Movies_MovieId",
                table: "FilmScheduleModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmScheduleModels",
                table: "FilmScheduleModels");

            migrationBuilder.RenameTable(
                name: "FilmScheduleModels",
                newName: "FilmSchedules");

            migrationBuilder.RenameIndex(
                name: "IX_FilmScheduleModels_MovieId",
                table: "FilmSchedules",
                newName: "IX_FilmSchedules_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmSchedules",
                table: "FilmSchedules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmSchedules_Movies_MovieId",
                table: "FilmSchedules",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmSchedules_Movies_MovieId",
                table: "FilmSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmSchedules",
                table: "FilmSchedules");

            migrationBuilder.RenameTable(
                name: "FilmSchedules",
                newName: "FilmScheduleModels");

            migrationBuilder.RenameIndex(
                name: "IX_FilmSchedules_MovieId",
                table: "FilmScheduleModels",
                newName: "IX_FilmScheduleModels_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmScheduleModels",
                table: "FilmScheduleModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmScheduleModels_Movies_MovieId",
                table: "FilmScheduleModels",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
