using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Modul_4_Task_4.Migrations
{
    public partial class InsertData1 : Migration
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
                                    VALUES('Night Witches', 206, '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Heavy metal'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Living The Dream', 205, '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Rock'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Ever Dream', 270, '{new DateTime(2013, 8, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Rock'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Lyfjaberg', 507, '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Folk metal'))");
            migrationBuilder.Sql(@$"INSERT INTO Song(Title, Duration, RelesedDate, GenreId) 
                                    VALUES('Ночные Ведьмы', 206, '{new DateTime(2020, 8, 3, 0, 0, 0, 0).ToString("s")}', 
                                    (SELECT Id FROM Genre WHERE Title = 'Heavy metal'))");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Night Witches' and 
                                                Duration = 206 and
                                                RelesedDate = '{new DateTime(2014, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Heavy metal')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Living The Dream' and 
                                                Duration = 205 and
                                                RelesedDate = '{new DateTime(2020, 7, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Ever Dream' and 
                                                Duration = 270 and
                                                RelesedDate = '{new DateTime(2013, 8, 3, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Rock')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Lyfjaberg' and 
                                                Duration = 507 and
                                                RelesedDate = '{new DateTime(2020, 5, 5, 0, 0, 0, 0).ToString("s")}' and
                                                GenreId = (SELECT Id FROM Genre WHERE Title = 'Folk metal')");
            migrationBuilder.Sql(@$"DELETE FROM Song 
                                                WHERE Title = 'Ночные Ведьмы' and 
                                                Duration = 206 and
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
