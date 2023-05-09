using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class bytabokstav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSupportSupport_Supports_supportsId",
                table: "StoreSupportSupport");

            migrationBuilder.RenameColumn(
                name: "supportsId",
                table: "StoreSupportSupport",
                newName: "SupportsId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreSupportSupport_supportsId",
                table: "StoreSupportSupport",
                newName: "IX_StoreSupportSupport_SupportsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSupportSupport_Supports_SupportsId",
                table: "StoreSupportSupport",
                column: "SupportsId",
                principalTable: "Supports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSupportSupport_Supports_SupportsId",
                table: "StoreSupportSupport");

            migrationBuilder.RenameColumn(
                name: "SupportsId",
                table: "StoreSupportSupport",
                newName: "supportsId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreSupportSupport_SupportsId",
                table: "StoreSupportSupport",
                newName: "IX_StoreSupportSupport_supportsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSupportSupport_Supports_supportsId",
                table: "StoreSupportSupport",
                column: "supportsId",
                principalTable: "Supports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
