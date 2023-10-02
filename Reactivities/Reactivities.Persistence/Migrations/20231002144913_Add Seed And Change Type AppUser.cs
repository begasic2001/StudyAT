using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedAndChangeTypeAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0c907e19-7354-4e3f-86b7-4299e72b2325"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("44ebcf40-521c-487d-890a-823b92107d6b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4d6ca198-33d0-417c-9ba3-966300141259"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("76ceb8fe-44bc-4f67-9dfd-3190a9501691"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cd92123a-1045-4d55-975a-499ed40b06b0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d4cc3c79-a8a6-468c-a116-d497b58b24af"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e88946c8-2b50-49d0-8d6f-e6ae3d372ddb"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e910222b-06c7-4008-b1b3-5ba39d3865c9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f1ff2bcb-df7d-4413-b9ea-abcef96930ce"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f9d1f61c-193e-4cc4-99a9-2260c7008e4d"));

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("0c907e19-7354-4e3f-86b7-4299e72b2325"), "drinks", "London", new DateTime(2023, 8, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2248), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("44ebcf40-521c-487d-890a-823b92107d6b"), "culture", "London", new DateTime(2023, 11, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2261), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("4d6ca198-33d0-417c-9ba3-966300141259"), "music", "London", new DateTime(2024, 4, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2284), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("76ceb8fe-44bc-4f67-9dfd-3190a9501691"), "drinks", "London", new DateTime(2024, 1, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2267), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("cd92123a-1045-4d55-975a-499ed40b06b0"), "film", "London", new DateTime(2024, 6, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2290), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("d4cc3c79-a8a6-468c-a116-d497b58b24af"), "drinks", "London", new DateTime(2024, 3, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2272), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("e88946c8-2b50-49d0-8d6f-e6ae3d372ddb"), "music", "London", new DateTime(2023, 12, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2265), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("e910222b-06c7-4008-b1b3-5ba39d3865c9"), "culture", "Paris", new DateTime(2023, 9, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2258), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("f1ff2bcb-df7d-4413-b9ea-abcef96930ce"), "drinks", "London", new DateTime(2024, 2, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2270), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("f9d1f61c-193e-4cc4-99a9-2260c7008e4d"), "travel", "London", new DateTime(2024, 5, 2, 13, 50, 33, 460, DateTimeKind.Utc).AddTicks(2287), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" }
                });
        }
    }
}
