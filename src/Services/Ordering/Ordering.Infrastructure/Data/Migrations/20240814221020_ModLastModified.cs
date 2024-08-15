using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ordering.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModLastModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Products",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Orders",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "OrderItems",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Customers",
                newName: "LastModifiedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Products",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Orders",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "OrderItems",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Customers",
                newName: "LastModified");
        }
    }
}
