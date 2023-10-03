using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Changeseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1e30fc5f-4458-49b5-8723-ceba94d1a694"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("22442771-c585-4983-a599-8632949886aa"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("456c20de-6fd8-4919-8629-040c4c0d48d9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5fd4eef0-1e45-44a2-a73b-006118fb1e71"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("79e6c02d-d932-4e1f-9057-cef1503c3b31"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("80273ed9-888f-42b6-9c44-95bcba4e9b1c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b08260e5-bde1-4c6a-b02d-4bcd9b2a1805"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ba3b93cd-04b0-4a0d-8fda-ca864a31b034"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d191a982-8cc5-4c4f-9d14-ff80ef2579e1"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f0ed79e9-3260-4e42-92f4-0e00b8bb35c3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69db53db-fd28-427d-bb0a-b974afca3941");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78038b8f-5e6d-40db-b3bd-431e91c4c04f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad14796d-b212-4aec-ac11-86f77e99822b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f773d3f1-8593-429c-bc3d-662f49d13943");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("165f96b5-8b76-4aea-aa67-702a5d709663"), "culture", "Paris", new DateTime(2023, 9, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3681), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("1d9448fb-6867-485f-bbc7-35037ba4b26d"), "drinks", "London", new DateTime(2023, 8, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3671), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("2cde01f5-806d-4023-934b-2fe449860bc2"), "film", "London", new DateTime(2024, 6, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3723), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("3f98e72f-3eb9-47c5-83f6-bc4ea4e666c1"), "drinks", "London", new DateTime(2024, 3, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3696), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("879494bc-e6fd-498b-a14e-91a9b539a1e9"), "music", "London", new DateTime(2023, 12, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3687), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("ae72ba70-8730-4fc7-a992-75aca2e3e3b5"), "culture", "London", new DateTime(2023, 11, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3685), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("bf705cd6-c763-41db-81f5-bb7aa618d1d9"), "drinks", "London", new DateTime(2024, 1, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3691), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("c0927bbb-578e-4cff-a67d-1e6c6969f98e"), "travel", "London", new DateTime(2024, 5, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3721), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("c8a70839-170f-4a02-876a-960e496f81af"), "music", "London", new DateTime(2024, 4, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3716), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("e45e00a3-bfea-4ba5-825c-d3fa8a7aefa1"), "drinks", "London", new DateTime(2024, 2, 3, 17, 0, 21, 535, DateTimeKind.Utc).AddTicks(3693), "Activity 4 months in future", "Future Activity 4", "Yet another pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("165f96b5-8b76-4aea-aa67-702a5d709663"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1d9448fb-6867-485f-bbc7-35037ba4b26d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2cde01f5-806d-4023-934b-2fe449860bc2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f98e72f-3eb9-47c5-83f6-bc4ea4e666c1"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("879494bc-e6fd-498b-a14e-91a9b539a1e9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ae72ba70-8730-4fc7-a992-75aca2e3e3b5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("bf705cd6-c763-41db-81f5-bb7aa618d1d9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c0927bbb-578e-4cff-a67d-1e6c6969f98e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c8a70839-170f-4a02-876a-960e496f81af"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e45e00a3-bfea-4ba5-825c-d3fa8a7aefa1"));

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("1e30fc5f-4458-49b5-8723-ceba94d1a694"), "drinks", "London", new DateTime(2024, 1, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6373), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("22442771-c585-4983-a599-8632949886aa"), "drinks", "London", new DateTime(2024, 2, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6378), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("456c20de-6fd8-4919-8629-040c4c0d48d9"), "culture", "Paris", new DateTime(2023, 9, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6334), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("5fd4eef0-1e45-44a2-a73b-006118fb1e71"), "music", "London", new DateTime(2024, 4, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6384), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("79e6c02d-d932-4e1f-9057-cef1503c3b31"), "drinks", "London", new DateTime(2023, 8, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6318), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("80273ed9-888f-42b6-9c44-95bcba4e9b1c"), "music", "London", new DateTime(2023, 12, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6367), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("b08260e5-bde1-4c6a-b02d-4bcd9b2a1805"), "film", "London", new DateTime(2024, 6, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6390), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("ba3b93cd-04b0-4a0d-8fda-ca864a31b034"), "travel", "London", new DateTime(2024, 5, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6387), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("d191a982-8cc5-4c4f-9d14-ff80ef2579e1"), "drinks", "London", new DateTime(2024, 3, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6381), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("f0ed79e9-3260-4e42-92f4-0e00b8bb35c3"), "culture", "London", new DateTime(2023, 11, 2, 14, 49, 13, 284, DateTimeKind.Utc).AddTicks(6360), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69db53db-fd28-427d-bb0a-b974afca3941", 0, null, "cf21f31b-e50d-488e-948d-dfcc0cf4953c", "Mi ong", "miong@gmail.com", false, false, null, null, null, "123456", null, false, "22864308-ad47-4808-a937-52744f6eebbc", false, "Miong" },
                    { "78038b8f-5e6d-40db-b3bd-431e91c4c04f", 0, null, "cbe22d9c-838d-41ef-bf7f-51f18962e1be", "Jenifer", "jenifer@gmail.com", false, false, null, null, null, "123456", null, false, "254f21c8-1763-4133-a940-5f4061cc4d58", false, "jenifer" },
                    { "ad14796d-b212-4aec-ac11-86f77e99822b", 0, null, "7de7c640-82a1-482d-8c3f-55227318111f", "Mi mi", "mimi@gmail.com", false, false, null, null, null, "123456", null, false, "83a877ca-4057-4c08-b946-1e1e15c376f3", false, "Mimi" },
                    { "f773d3f1-8593-429c-bc3d-662f49d13943", 0, null, "d835ff25-f17a-45cf-9d30-f9bda7a76059", "Mi panda", "mipanda@gmail.com", false, false, null, null, null, "123456", null, false, "dd19256c-d2ae-4ed6-b9ea-9f8bcac97334", false, "Mipanda" }
                });
        }
    }
}
