using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryBeginners.Migrations
{
    public partial class StockTranLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockTranLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    productCode = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    PoHeaderId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTranLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockTranLogs_PoHeaders_PoHeaderId",
                        column: x => x.PoHeaderId,
                        principalTable: "PoHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTranLogs_Products_productCode",
                        column: x => x.productCode,
                        principalTable: "Products",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_StockTranLogs_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockTranLogs_PoHeaderId",
                table: "StockTranLogs",
                column: "PoHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTranLogs_productCode",
                table: "StockTranLogs",
                column: "productCode");

            migrationBuilder.CreateIndex(
                name: "IX_StockTranLogs_UnitId",
                table: "StockTranLogs",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTranLogs");
        }
    }
}
