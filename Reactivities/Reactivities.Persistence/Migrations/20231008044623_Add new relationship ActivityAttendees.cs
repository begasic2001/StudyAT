using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddnewrelationshipActivityAttendees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ActivityAttendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsHost = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAttendees", x => new { x.ActivityId, x.AppUserId });
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("13d8e975-72fe-4b01-8bad-4d1bda0f0dba"), "travel", "London", new DateTime(2024, 5, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8253), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("1618ce0b-18d1-4a00-9de6-a091f933a21f"), "drinks", "London", new DateTime(2023, 8, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8215), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("45717148-3bd6-4478-b73f-5f582df9afe2"), "music", "London", new DateTime(2024, 4, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8247), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("57e1d75b-fb07-442a-b177-b5dfc0929216"), "film", "London", new DateTime(2024, 6, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8256), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("5fc376c7-7d42-452d-a410-cd089c9d40f8"), "drinks", "London", new DateTime(2024, 3, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8245), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("9a1fe0b7-c074-4432-aa16-e97d2ddda881"), "culture", "Paris", new DateTime(2023, 9, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8229), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("ab750b4a-9fa4-4fb0-81f6-edb4b322d212"), "culture", "London", new DateTime(2023, 11, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8232), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("b8ad1e24-7eb9-4e35-8544-0970994f5502"), "music", "London", new DateTime(2023, 12, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8235), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("eea9ac3d-f79b-4daa-a2ed-ceb62276b722"), "drinks", "London", new DateTime(2024, 2, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8242), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("fe3194e4-4b75-4660-a6ff-c9d101c56a5f"), "drinks", "London", new DateTime(2024, 1, 8, 4, 46, 23, 105, DateTimeKind.Utc).AddTicks(8238), "Activity 3 months in future", "Future Activity 3", "Another pub" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttendees_AppUserId",
                table: "ActivityAttendees",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAttendees");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("13d8e975-72fe-4b01-8bad-4d1bda0f0dba"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1618ce0b-18d1-4a00-9de6-a091f933a21f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("45717148-3bd6-4478-b73f-5f582df9afe2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("57e1d75b-fb07-442a-b177-b5dfc0929216"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5fc376c7-7d42-452d-a410-cd089c9d40f8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9a1fe0b7-c074-4432-aa16-e97d2ddda881"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ab750b4a-9fa4-4fb0-81f6-edb4b322d212"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b8ad1e24-7eb9-4e35-8544-0970994f5502"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("eea9ac3d-f79b-4daa-a2ed-ceb62276b722"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fe3194e4-4b75-4660-a6ff-c9d101c56a5f"));

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
    }
}
