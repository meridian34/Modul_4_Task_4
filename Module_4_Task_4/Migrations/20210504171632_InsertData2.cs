using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Modul_4_Task_4.Migrations
{
    public partial class InsertData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Sabaton' and 
                                                DateOfBirth = '{new DateTime(1999, 8, 3, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Night Witches' and
                                                Duration = 206 and
                                                RelesedDate = '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'FFDP' and 
                                                DateOfBirth = '{new DateTime(2005, 7, 1, 0, 0, 0, 0).ToString("s")}' ),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Living The Dream' and
                                                Duration = 205 and
                                                RelesedDate = '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Nightwish' and 
                                                DateOfBirth = '{new DateTime(1996, 6, 5, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Ever Dream' and
                                                Duration = 270 and
                                                RelesedDate = '{new DateTime(2013, 8, 3, 0, 0, 0, 0).Date.ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Wardruna' and 
                                                DateOfBirth = '{new DateTime(2003, 8, 3, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Lyfjaberg' and
                                                Duration = 507 and
                                                RelesedDate = '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Folk metal')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Radio Tapok' and 
                                                DateOfBirth = '{new DateTime(2016, 5, 3, 0, 0, 0, 0).ToString("s")}' ),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Ночные Ведьмы' and
                                                Duration = 206 and
                                                RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')))");

            migrationBuilder.Sql(@$"INSERT INTO ArtistSong(ArtistId,SongId) 
                                    VALUES((SELECT Id FROM Artist 
                                                WHERE Name = 'Sabaton' and 
                                                DateOfBirth = '{new DateTime(1999, 8, 3, 0, 0, 0, 0).ToString("s")}'),
                                            (SELECT Id FROM Song
                                                WHERE Title = 'Ночные Ведьмы' and
                                                Duration = 206 and
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
                                                             Duration = 206 and
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
                                                              Duration = 205 and
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
                                                            Duration = 270 and
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
                                                            Duration = 507 and
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
                                                            Duration = 206 and
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
                                                            Duration = 206 and
                                                            RelesedDate = '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                            GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");
        }
    }
}
