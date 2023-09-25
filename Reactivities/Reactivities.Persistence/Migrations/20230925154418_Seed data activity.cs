using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeddataactivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("1710f0d1-f873-4364-88b7-b4a3e96bc716"), "travel", "London", new DateTime(2024, 4, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4120), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("46accda4-a920-4485-9c1f-cadddfdee6d3"), "drinks", "London", new DateTime(2024, 2, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4115), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("5ae4508b-f327-4f4b-9c99-429dc42e5d3f"), "drinks", "London", new DateTime(2024, 1, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4112), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("5d01e52c-234e-483e-8078-8353dc7845b5"), "drinks", "London", new DateTime(2023, 12, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4109), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("81878cbd-22d4-427e-aaea-deee106811c9"), "culture", "London", new DateTime(2023, 10, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4083), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("81b377b6-eee8-43c0-b233-7987a95180e1"), "music", "London", new DateTime(2023, 11, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4086), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("8ad26443-ed57-4956-b980-edac70b7cb3b"), "music", "London", new DateTime(2024, 3, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4118), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("95a23bcd-ca37-48be-968b-96da9e92e219"), "film", "London", new DateTime(2024, 5, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4123), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("9b368a89-f5da-4818-8fe8-85be50720a03"), "culture", "Paris", new DateTime(2023, 8, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4081), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("a410364f-6c61-41e7-943e-523047e50036"), "drinks", "London", new DateTime(2023, 7, 25, 15, 44, 17, 901, DateTimeKind.Utc).AddTicks(4065), "Activity 2 months ago", "Past Activity 1", "Pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1710f0d1-f873-4364-88b7-b4a3e96bc716"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("46accda4-a920-4485-9c1f-cadddfdee6d3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5ae4508b-f327-4f4b-9c99-429dc42e5d3f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5d01e52c-234e-483e-8078-8353dc7845b5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("81878cbd-22d4-427e-aaea-deee106811c9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("81b377b6-eee8-43c0-b233-7987a95180e1"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8ad26443-ed57-4956-b980-edac70b7cb3b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("95a23bcd-ca37-48be-968b-96da9e92e219"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9b368a89-f5da-4818-8fe8-85be50720a03"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a410364f-6c61-41e7-943e-523047e50036"));
        }
    }
}
