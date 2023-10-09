using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefactorSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("02793109-ddcd-47f3-88e7-f8e9a03e29bd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("113ef67c-da07-4356-9008-95d72040c560"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("21a7bda3-da91-4c33-aa47-4892e2b26b6c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5f4ea299-80ec-486d-b6ad-e5d9bc396158"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("61fc29e1-4608-4df5-88c9-8e5770ad2ddc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("63b63cfd-d708-45e0-988e-5fe897fff718"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("825bed9f-a07d-49ff-9e87-2f365cf86655"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8a446504-4771-42ac-97e0-7dc8e3b912c5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("96585622-7480-40ca-913a-66d8fd9eaf4f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("defd3df2-597e-4b61-a31e-9a1f2eeea533"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("02793109-ddcd-47f3-88e7-f8e9a03e29bd"), "drinks", "London", new DateTime(2024, 1, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4353), "Activity 3 months in future", false, "Future Activity 3", "Another pub" },
                    { new Guid("113ef67c-da07-4356-9008-95d72040c560"), "culture", "Paris", new DateTime(2023, 9, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4342), "Activity 1 month ago", false, "Past Activity 2", "Louvre" },
                    { new Guid("21a7bda3-da91-4c33-aa47-4892e2b26b6c"), "culture", "London", new DateTime(2023, 11, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4346), "Activity 1 month in future", false, "Future Activity 1", "Natural History Museum" },
                    { new Guid("5f4ea299-80ec-486d-b6ad-e5d9bc396158"), "drinks", "London", new DateTime(2024, 2, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4357), "Activity 4 months in future", false, "Future Activity 4", "Yet another pub" },
                    { new Guid("61fc29e1-4608-4df5-88c9-8e5770ad2ddc"), "travel", "London", new DateTime(2024, 5, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4386), "Activity 2 months ago", false, "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("63b63cfd-d708-45e0-988e-5fe897fff718"), "music", "London", new DateTime(2024, 4, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4383), "Activity 6 months in future", false, "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("825bed9f-a07d-49ff-9e87-2f365cf86655"), "drinks", "London", new DateTime(2024, 3, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4379), "Activity 5 months in future", false, "Future Activity 5", "Just another pub" },
                    { new Guid("8a446504-4771-42ac-97e0-7dc8e3b912c5"), "music", "London", new DateTime(2023, 12, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4350), "Activity 2 months in future", false, "Future Activity 2", "O2 Arena" },
                    { new Guid("96585622-7480-40ca-913a-66d8fd9eaf4f"), "film", "London", new DateTime(2024, 6, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4390), "Activity 8 months in future", false, "Future Activity 8", "Cinema" },
                    { new Guid("defd3df2-597e-4b61-a31e-9a1f2eeea533"), "drinks", "London", new DateTime(2023, 8, 8, 11, 28, 23, 300, DateTimeKind.Utc).AddTicks(4329), "Activity 2 months ago", false, "Past Activity 1", "Pub" }
                });
        }
    }
}
