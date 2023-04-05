using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentaalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Vehicles",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Vehicles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Models",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Models",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Makes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Makes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Customers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Colours",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Colours",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Bookings",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Bookings",
                newName: "DateCreated");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7377a19a-1e1a-4911-9670-f98176f86c35", "6759a19a-1e1a-4911-9670-f98176f86cee" },
                    { "e80c51ef-5797-47ee-813a-a8deca800085", "e75c51ef-5797-47ee-813a-a8deca600c75" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6759a19a-1e1a-4911-9670-f98176f86cee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f486009-de4b-44a9-afa8-d518a533941d", "AQAAAAIAAYagAAAAEMihYS8Q46WjKxLww9zhdR6znJAVj3fGwVztdOD5bK9gtd7gTm7tL9Hg2Z6w7+9yuw==", "89808056-48e1-40e3-915e-fc08b8f41f65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e75c51ef-5797-47ee-813a-a8deca600c75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b293fe-b42e-4ea1-9b09-c1e04eadf0de", "AQAAAAIAAYagAAAAEGrokeknJdpEpklFTiwt0H+6r8T28ictzWY/QOZN1eBTlUaFMvWrIYIucrN+bWhiUQ==", "c359e8f2-7d65-4bdd-9990-860c62b07eac" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6437), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6441), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 4, 5, 16, 21, 12, 672, DateTimeKind.Local).AddTicks(6443) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7377a19a-1e1a-4911-9670-f98176f86c35", "6759a19a-1e1a-4911-9670-f98176f86cee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e80c51ef-5797-47ee-813a-a8deca800085", "e75c51ef-5797-47ee-813a-a8deca600c75" });

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicles",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicles",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Models",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Models",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Makes",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Makes",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customers",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Colours",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Colours",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Bookings",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Bookings",
                newName: "DataCreated");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6759a19a-1e1a-4911-9670-f98176f86cee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "039d75db-7f05-4824-a1e3-c49454e7f6af", "AQAAAAIAAYagAAAAEGG9GHkLfLBt9gu8oRPz0FsZ9AXRL+0Tm8An0CSZ2aqNJYmqqVPXal0WRRIoZyNFZg==", "c94e97b6-8fda-4899-bcf3-070e9e170460" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e75c51ef-5797-47ee-813a-a8deca600c75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea15b07-0d3a-4aef-ae2d-562d3a27a185", "AQAAAAIAAYagAAAAEKNWXmde+UcSCE7VPeHu1Wn7KV17oNWkfgdwfHrdvxauQoMukoCAtFk/xga81BTUug==", "a1d1f430-ad41-46fd-a49b-f8e3f776c121" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(1868), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(1883), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2415), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2418), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DataUpdated" },
                values: new object[] { new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2420), new DateTime(2023, 4, 2, 22, 35, 29, 438, DateTimeKind.Local).AddTicks(2421) });
        }
    }
}
