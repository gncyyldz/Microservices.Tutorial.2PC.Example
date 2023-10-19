using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1616f169-6626-4f90-88d7-04354a553e39"), "Stock.API" },
                    { new Guid("16d03031-9dec-44e2-be58-5a48c6cbd04f"), "Order.API" },
                    { new Guid("3ba27b41-a1d9-4073-8489-f6c2046e2e57"), "Payment.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("1616f169-6626-4f90-88d7-04354a553e39"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("16d03031-9dec-44e2-be58-5a48c6cbd04f"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("3ba27b41-a1d9-4073-8489-f6c2046e2e57"));
        }
    }
}
