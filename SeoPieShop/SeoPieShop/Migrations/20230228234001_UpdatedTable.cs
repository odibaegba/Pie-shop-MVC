using Microsoft.EntityFrameworkCore.Migrations;

namespace SeoPieShop.Migrations
{
    public partial class UpdatedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_Pies_PieId",
                table: "orderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_PieId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_PieId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_PieId",
                table: "orderDetails",
                newName: "IX_orderDetails_PieId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "orderDetails",
                newName: "IX_orderDetails_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_Pies_PieId",
                table: "orderDetails",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
