using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class addingreplies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreSupport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreSupport", x => x.Id);
                });

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
                        name: "FK_StoreSupportSupport_StoreSupport_StoreSupportsId",
                        column: x => x.StoreSupportsId,
                        principalTable: "StoreSupport",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreSupportSupport");

            migrationBuilder.DropTable(
                name: "StoreSupport");
        }
    }
}
