using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class FixNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Movies_MovieId",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_actors_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producers",
                table: "producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actors",
                table: "actors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "Producers");

            migrationBuilder.RenameTable(
                name: "cinemas",
                newName: "Cinemas");

            migrationBuilder.RenameTable(
                name: "actors",
                newName: "Actors");

            migrationBuilder.RenameTable(
                name: "Actor_Movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePicURL",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "cost",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PosterURL",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "LogoPicURL",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "ProfilePicURL",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "producers");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "cinemas");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "actors");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actor_Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "producers",
                newName: "ProfilePicURL");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "producers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "cost");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "PosterURL");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "cinemas",
                newName: "LogoPicURL");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "actors",
                newName: "ProfilePicURL");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "actors",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actor_Movies",
                newName: "IX_Actor_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actors",
                table: "actors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Movies_MovieId",
                table: "Actor_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_actors_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
