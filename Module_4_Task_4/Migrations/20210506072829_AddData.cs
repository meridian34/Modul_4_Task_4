using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Modul_4_Task_4.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Name", "DateOfBirth", "Phone", "Email", "InstagramUrl" },
                values: new object[,]
                {
                    {"Sabaton",new DateTime(1999, 8, 3, 0, 0, 0, 0),null,null,null },
                    {"FFDP",new DateTime(2005, 7, 1, 0, 0, 0, 0),null,null,null },
                    {"Nightwish",new DateTime(1996, 6, 5, 0, 0, 0, 0),null,null,null },
                    {"Wardruna",new DateTime(2003, 8, 3, 0, 0, 0, 0),null,null,null },
                    {"Radio Tapok",new DateTime(2016, 5, 3, 0, 0, 0, 0),null,null,null },
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Title" },
                values: new object[,]
                {
                    { "Rock" },
                    { "Clasic" },
                    { "Pop" },
                    { "Heavy metal" },
                    { "Folk metal" }
                });

            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Night Witches', '{new TimeSpan(0,3,26)}', '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Heavy metal'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Living The Dream', '{new TimeSpan(0, 3, 25)}', '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Rock'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Ever Dream', '{new TimeSpan(0, 4, 30)}', '{new DateTime(2013, 8, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Rock'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Lyfjaberg', '{new TimeSpan(0, 8, 27)}', '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Folk metal'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Ночные Ведьмы', '{new TimeSpan(0, 3, 26)}', '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Heavy metal'))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Sabaton' and 
                                                DateOfBirth = '{new DateTime(1999, 8, 3, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Night Witches' and
                                                Duration = '{new TimeSpan(0, 3, 26)}' and
                                                RelesedDate = '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'FFDP' and 
                                                DateOfBirth = '{new DateTime(2005, 7, 1, 0, 0, 0, 0).ToString("s")}' ),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Living The Dream' and
                                                Duration = '{new TimeSpan(0, 3, 25)}' and
                                                RelesedDate = '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Nightwish' and 
                                                DateOfBirth = '{new DateTime(1996, 6, 5, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Ever Dream' and
                                                Duration = '{new TimeSpan(0, 4, 30)}' and
                                                RelesedDate = '{new DateTime(2013, 8, 3, 0, 0, 0, 0).Date.ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Wardruna' and 
                                                DateOfBirth = '{new DateTime(2003, 8, 3, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Lyfjaberg' and
                                                Duration = '{new TimeSpan(0, 8, 27)}' and
                                                RelesedDate = '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Folk metal')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Radio Tapok' and 
                                                DateOfBirth = '{new DateTime(2016, 5, 3, 0, 0, 0, 0).ToString("s")}' ),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Ночные Ведьмы' and
                                                Duration = '{new TimeSpan(0, 3, 26)}' and
                                                RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Sabaton' and 
                                                DateOfBirth = '{new DateTime(1999, 8, 3, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Ночные Ведьмы' and
                                                Duration = '{new TimeSpan(0, 3, 26)}' and
                                                RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"DELETE FROM AristSong
                                           WHERE ArtistId = (SELECT Id FROM Artist 
                                                             WHERE Name = 'Sabaton' and 
                                                             DateOfBirth = '{new DateTime(1999, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                             Phone = null and
                                                             Email = null and
                                                             InstagramUrl = null) and
                                                SongId = (SELECT Id FROM Song
                                                             WHERE Title = 'Night Witches' and
                                                             Duration = '{new TimeSpan(0, 3, 26)}' and
                                                             RelesedDate = '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                             GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");

            migrationBuilder.Sql(@$"DELETE FROM AristSong
                                           WHERE ArtistId = (SELECT Id FROM Artist 
                                                             WHERE Name = 'FFDP' and 
                                                             DateOfBirth = '{new DateTime(2005, 7, 1, 0, 0, 0, 0).ToString("s")}' and
                                                             Phone = null and
                                                             Email = null and
                                                             InstagramUrl = null) and
                                                SongId = (SELECT Id FROM Song
                                                             HERE Title = 'Living The Dream' and
                                                              Duration = '{new TimeSpan(0, 3, 25)}' and
                                                              RelesedDate = '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}' and
                                                             GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')");

            migrationBuilder.Sql(@$"DELETE FROM AristSong
                                           WHERE ArtistId = (SELECT Id FROM Artist 
                                                             WHERE Name = 'Nightwish' and 
                                                             DateOfBirth = '{new DateTime(1996, 6, 5, 0, 0, 0, 0).ToString("s")}' and
                                                             Phone = null and
                                                             Email = null and
                                                             InstagramUrl = null) and
                                                SongId = (SELECT Id FROM Song
                                                            WHERE Title = 'Ever Dream' and
                                                            Duration = '{new TimeSpan(0, 4, 30)}' and
                                                            RelesedDate = '{new DateTime(2013, 8, 3, 0, 0, 0, 0).Date.ToString("s")}' and
                                                            GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')");

            migrationBuilder.Sql(@$"DELETE FROM AristSong
                                           WHERE ArtistId = (SELECT Id FROM Artist 
                                                             WHERE Name = 'Wardruna' and 
                                                             DateOfBirth = '{new DateTime(2003, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                             Phone = null and
                                                             Email = null and
                                                             InstagramUrl = null) and
                                                SongId = (SELECT Id FROM Song
                                                            WHERE Title = 'Lyfjaberg' and
                                                            Duration = '{new TimeSpan(0, 8, 27)}' and
                                                            RelesedDate = '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}' and
                                                            GenreId = (SELECT Id FROM Genre WHERE Title = 'Folk metal')");

            migrationBuilder.Sql(@$"DELETE FROM AristSong
                                           WHERE ArtistId = (SELECT Id FROM Artist 
                                                            WHERE Name = 'Radio Tapok' and 
                                                            DateOfBirth = '{new DateTime(2016, 5, 3, 0, 0, 0, 0).ToString("s")}' and
                                                            Phone = null and
                                                            Email = null and
                                                            InstagramUrl = null) and
                                                SongId = (SELECT Id FROM Song
                                                            WHERE Title = 'Ночные Ведьмы' and
                                                            Duration = '{new TimeSpan(0, 3, 26)}' and
                                                            RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                            GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");


            migrationBuilder.Sql(@$"DELETE FROM AristSong
                                           WHERE ArtistId = (SELECT Id FROM Artist 
                                                            WHERE Name = 'Sabaton' and 
                                                            DateOfBirth = '{new DateTime(1999, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                            Phone = null and
                                                            Email = null and
                                                            InstagramUrl = null) and
                                                SongId = (SELECT Id FROM Song
                                                            WHERE Title = 'Ночные Ведьмы' and
                                                            Duration = '{new TimeSpan(0, 3, 26)}' and
                                                            RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                            GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");

            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Night Witches' and 
                                                Duration = '{new TimeSpan(0, 3, 26)}' and
                                                RelesedDate = '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Living The Dream' and 
                                                Duration = '{new TimeSpan(0, 3, 25)}' and
                                                RelesedDate = '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Ever Dream' and 
                                                Duration = '{new TimeSpan(0, 4, 30)}' and
                                                RelesedDate = '{new DateTime(2013, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Lyfjaberg' and 
                                                Duration = '{new TimeSpan(0, 8, 27)}' and
                                                RelesedDate = '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Folk metal')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Ночные Ведьмы' and 
                                                Duration = '{new TimeSpan(0, 3, 26)}' and
                                                RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumns: new[] { "Title" },
                keyValues: new object[,]
                {
                    { "Rock" },
                    { "Clasic" },
                    { "Pop" },
                    { "Heavy metal" },
                    { "Folk metal" }
                });

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumns: new[] { "Name", "DateOfBirth", "Phone", "Email", "InstagramUrl" },
                keyValues: new object[,]
                {
                    {"Sabaton",new DateTime(1999, 8, 3, 0, 0, 0, 0),null,null,null },
                    {"FFDP",new DateTime(2005, 7, 1, 0, 0, 0, 0),null,null,null },
                    {"Nightwish",new DateTime(1996, 6, 5, 0, 0, 0, 0),null,null,null },
                    {"Wardruna",new DateTime(2003, 8, 3, 0, 0, 0, 0),null,null,null },
                    {"Radio Tapok",new DateTime(2016, 5, 3, 0, 0, 0, 0),null,null,null },
                });
        }
    }
}
