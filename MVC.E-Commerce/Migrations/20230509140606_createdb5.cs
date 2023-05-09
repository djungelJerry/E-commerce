using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class createdb5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreSupportSupport");

            migrationBuilder.AddColumn<bool>(
                name: "IsCustomer",
                table: "StoreSupports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SupportId",
                table: "StoreSupports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StoreSupports_SupportId",
                table: "StoreSupports",
                column: "SupportId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSupports_Supports_SupportId",
                table: "StoreSupports",
                column: "SupportId",
                principalTable: "Supports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSupports_Supports_SupportId",
                table: "StoreSupports");

            migrationBuilder.DropIndex(
                name: "IX_StoreSupports_SupportId",
                table: "StoreSupports");

            migrationBuilder.DropColumn(
                name: "IsCustomer",
                table: "StoreSupports");

            migrationBuilder.DropColumn(
                name: "SupportId",
                table: "StoreSupports");

            migrationBuilder.CreateTable(
                name: "StoreSupportSupport",
                columns: table => new
                {
                    StoreSupportsId = table.Column<int>(type: "int", nullable: false),
                    SupportsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreSupportSupport", x => new { x.StoreSupportsId, x.SupportsId });
                    table.ForeignKey(
                        name: "FK_StoreSupportSupport_StoreSupports_StoreSupportsId",
                        column: x => x.StoreSupportsId,
                        principalTable: "StoreSupports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreSupportSupport_Supports_SupportsId",
                        column: x => x.SupportsId,
                        principalTable: "Supports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreSupportSupport_SupportsId",
                table: "StoreSupportSupport",
                column: "SupportsId");
        }
    }
}
