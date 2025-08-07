using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineAimane.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecee7176-9f65-468a-a0e0-544543ccf605", "1beea0be-b9a4-4f10-aeb1-8df3cafa6627" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecee7176-9f65-468a-a0e0-544543ccf605");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1beea0be-b9a4-4f10-aeb1-8df3cafa6627");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bc37984-a416-4054-85cf-9309a0880ec0", "6d2f0226-6705-4c72-9d4f-3500a6ce6514", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "57df53ea-9aea-453b-ba1b-097a98d9766a", 0, "62e483a6-c188-4bee-94e8-1587a61c7367", "aimanecouissi@gmail.com", true, true, null, "AIMANECOUISSI@GMAIL.COM", "AIMANECOUISSI", "AQAAAAEAACcQAAAAEAZYtKSfI40QNLehDZ6E04Is1Shjij2AY5jjSBenkMONGpMBMzT1e4q626c+PIYiEA==", null, false, "53b90ff3-0aeb-40e9-afcf-8e6c0e910b13", false, "aimanecouissi" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7bc37984-a416-4054-85cf-9309a0880ec0", "57df53ea-9aea-453b-ba1b-097a98d9766a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7bc37984-a416-4054-85cf-9309a0880ec0", "57df53ea-9aea-453b-ba1b-097a98d9766a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bc37984-a416-4054-85cf-9309a0880ec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57df53ea-9aea-453b-ba1b-097a98d9766a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecee7176-9f65-468a-a0e0-544543ccf605", "f6f16544-b679-48ed-8513-d3d960d9507c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1beea0be-b9a4-4f10-aeb1-8df3cafa6627", 0, "f3e57121-53cc-43fb-b4de-196b93964b2a", "aimanecouissi@gmail.com", true, true, null, "AIMANECOUISSI@GMAIL.COM", "AIMANECOUISSI", "AQAAAAEAACcQAAAAEAKYkGvyrL3xSojbKCgWLskQ18U7vwfdqN87/0iouMCodG1uYPkIyG7ZtNFg337Q0g==", null, false, "14d7aecd-4bca-4688-b2e4-991cee48c967", false, "aimanecouissi" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ecee7176-9f65-468a-a0e0-544543ccf605", "1beea0be-b9a4-4f10-aeb1-8df3cafa6627" });
        }
    }
}
