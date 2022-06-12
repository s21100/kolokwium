using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kolokwium2b.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "IdAlbum", "AlbumName", "IdMusicLabel", "PublishDate" },
                values: new object[,]
                {
                    { 1, "AlbumName1", 1, new DateTime(2022, 6, 12, 8, 43, 47, 246, DateTimeKind.Local).AddTicks(2398) },
                    { 2, "AlbumName2", 2, new DateTime(2022, 6, 12, 8, 43, 47, 248, DateTimeKind.Local).AddTicks(7843) }
                });

            migrationBuilder.InsertData(
                table: "MusicLabels",
                columns: new[] { "IdMusicLabel", "Name" },
                values: new object[,]
                {
                    { 1, "TestName1" },
                    { 2, "TestName2" }
                });

            migrationBuilder.InsertData(
                table: "Musican_Tracks",
                columns: new[] { "IdMusician", "IdTrack" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Musicans",
                columns: new[] { "IdMusician", "FirstName", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 1, "Jan", "Kowalski", "nickname1" },
                    { 2, "Jan", "Nowak", "nickname2" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum", "TrackName" },
                values: new object[,]
                {
                    { 1, 3.4f, 1, "trackname1" },
                    { 2, 6.4f, 2, "trackname2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "IdMusicLabel",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "IdMusicLabel",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musican_Tracks",
                keyColumns: new[] { "IdMusician", "IdTrack" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Musican_Tracks",
                keyColumns: new[] { "IdMusician", "IdTrack" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "IdMusician",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "IdMusician",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 2);
        }
    }
}
