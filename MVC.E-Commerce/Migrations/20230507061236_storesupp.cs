using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class storesupp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSupportSupport_StoreSupport_StoreSupportsId",
                table: "StoreSupportSupport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreSupport",
                table: "StoreSupport");

            migrationBuilder.RenameTable(
                name: "StoreSupport",
                newName: "StoreSupports");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreSupports",
                table: "StoreSupports",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSupportSupport_StoreSupports_StoreSupportsId",
                table: "StoreSupportSupport",
                column: "StoreSupportsId",
                principalTable: "StoreSupports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSupportSupport_StoreSupports_StoreSupportsId",
                table: "StoreSupportSupport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreSupports",
                table: "StoreSupports");

            migrationBuilder.RenameTable(
                name: "StoreSupports",
                newName: "StoreSupport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreSupport",
                table: "StoreSupport",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSupportSupport_StoreSupport_StoreSupportsId",
                table: "StoreSupportSupport",
                column: "StoreSupportsId",
                principalTable: "StoreSupport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
