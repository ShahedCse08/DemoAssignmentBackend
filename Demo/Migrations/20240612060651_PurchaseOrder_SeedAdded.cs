using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Migrations
{
    public partial class PurchaseOrder_SeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PurchaseOrders",
                columns: new[] { "PurchaseOrderId", "ExpectedDate", "PurchaseOrderDate", "PurchaseOrderNumber", "ReferenceId", "Remarks", "SupplierId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 6, 11, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(4588), "PO001", 1, "Remark 1", 2 },
                    { 28, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 5, 15, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5708), "PO028", 28, "Remark 28", 2 },
                    { 27, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 5, 16, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5703), "PO027", 27, "Remark 27", 1 },
                    { 26, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 5, 17, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5697), "PO026", 26, "Remark 26", 3 },
                    { 25, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 5, 18, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5691), "PO025", 25, "Remark 25", 2 },
                    { 24, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5686), new DateTime(2024, 5, 19, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5685), "PO024", 24, "Remark 24", 1 },
                    { 23, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 5, 20, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5678), "PO023", 23, "Remark 23", 3 },
                    { 22, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 5, 21, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5628), "PO022", 22, "Remark 22", 2 },
                    { 21, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 5, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5622), "PO021", 21, "Remark 21", 1 },
                    { 20, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 5, 23, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5616), "PO020", 20, "Remark 20", 3 },
                    { 19, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5611), new DateTime(2024, 5, 24, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5610), "PO019", 19, "Remark 19", 2 },
                    { 18, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 5, 25, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5604), "PO018", 18, "Remark 18", 1 },
                    { 17, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 5, 26, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5597), "PO017", 17, "Remark 17", 3 },
                    { 16, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 5, 27, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5592), "PO016", 16, "Remark 16", 2 },
                    { 15, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 5, 28, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5586), "PO015", 15, "Remark 15", 1 },
                    { 14, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 5, 29, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5579), "PO014", 14, "Remark 14", 3 },
                    { 13, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5575), new DateTime(2024, 5, 30, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5573), "PO013", 13, "Remark 13", 2 },
                    { 12, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 5, 31, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5568), "PO012", 12, "Remark 12", 1 },
                    { 11, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5563), new DateTime(2024, 6, 1, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5562), "PO011", 11, "Remark 11", 3 },
                    { 10, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 6, 2, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5555), "PO010", 10, "Remark 10", 2 },
                    { 9, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 6, 3, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5546), "PO009", 9, "Remark 9", 1 },
                    { 8, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 6, 4, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5540), "PO008", 8, "Remark 8", 3 },
                    { 7, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 6, 5, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5534), "PO007", 7, "Remark 7", 2 },
                    { 6, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 6, 6, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5527), "PO006", 6, "Remark 6", 1 },
                    { 5, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 6, 7, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5519), "PO005", 5, "Remark 5", 3 },
                    { 4, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 6, 8, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5512), "PO004", 4, "Remark 4", 2 },
                    { 3, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5506), new DateTime(2024, 6, 9, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5505), "PO003", 3, "Remark 3", 1 },
                    { 2, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5482), new DateTime(2024, 6, 10, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5467), "PO002", 2, "Remark 2", 3 },
                    { 29, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 5, 14, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5715), "PO029", 29, "Remark 29", 3 },
                    { 30, new DateTime(2024, 6, 22, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 5, 13, 12, 6, 50, 932, DateTimeKind.Local).AddTicks(5721), "PO030", 30, "Remark 30", 1 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseOrderDetails",
                columns: new[] { "PurchaseOrderDetailId", "LineItemId", "PurchaseOrderId", "Quantity", "Rate" },
                values: new object[,]
                {
                    { 1, 3, 1, 20, 41.0m },
                    { 65, 7, 22, 30, 61.5m },
                    { 64, 6, 22, 20, 41.0m },
                    { 63, 7, 21, 40, 82.0m },
                    { 62, 6, 21, 30, 61.5m },
                    { 61, 5, 21, 20, 41.0m },
                    { 60, 6, 20, 40, 82.0m },
                    { 59, 5, 20, 30, 61.5m },
                    { 58, 4, 20, 20, 41.0m },
                    { 66, 8, 22, 40, 82.0m },
                    { 57, 5, 19, 40, 82.0m },
                    { 55, 3, 19, 20, 41.0m },
                    { 54, 4, 18, 40, 82.0m },
                    { 53, 3, 18, 30, 61.5m },
                    { 52, 2, 18, 20, 41.0m },
                    { 51, 3, 17, 40, 82.0m },
                    { 50, 2, 17, 30, 61.5m },
                    { 49, 1, 17, 20, 41.0m },
                    { 48, 2, 16, 40, 82.0m },
                    { 56, 4, 19, 30, 61.5m },
                    { 67, 7, 23, 20, 41.0m },
                    { 68, 8, 23, 30, 61.5m },
                    { 69, 9, 23, 40, 82.0m },
                    { 88, 5, 30, 20, 41.0m },
                    { 87, 6, 29, 40, 82.0m },
                    { 86, 5, 29, 30, 61.5m },
                    { 85, 4, 29, 20, 41.0m },
                    { 84, 5, 28, 40, 82.0m },
                    { 83, 4, 28, 30, 61.5m },
                    { 82, 3, 28, 20, 41.0m },
                    { 81, 4, 27, 40, 82.0m },
                    { 80, 3, 27, 30, 61.5m },
                    { 79, 2, 27, 20, 41.0m },
                    { 78, 3, 26, 40, 82.0m },
                    { 77, 2, 26, 30, 61.5m },
                    { 76, 1, 26, 20, 41.0m },
                    { 75, 2, 25, 40, 82.0m },
                    { 74, 1, 25, 30, 61.5m },
                    { 73, 9, 25, 20, 41.0m },
                    { 72, 1, 24, 40, 82.0m },
                    { 71, 9, 24, 30, 61.5m },
                    { 70, 8, 24, 20, 41.0m },
                    { 47, 1, 16, 30, 61.5m },
                    { 46, 9, 16, 20, 41.0m },
                    { 45, 1, 15, 40, 82.0m },
                    { 44, 9, 15, 30, 61.5m },
                    { 20, 1, 7, 30, 61.5m },
                    { 19, 9, 7, 20, 41.0m },
                    { 18, 1, 6, 40, 82.0m },
                    { 17, 9, 6, 30, 61.5m },
                    { 16, 8, 6, 20, 41.0m },
                    { 15, 9, 5, 40, 82.0m },
                    { 14, 8, 5, 30, 61.5m },
                    { 13, 7, 5, 20, 41.0m },
                    { 12, 8, 4, 40, 82.0m },
                    { 11, 7, 4, 30, 61.5m },
                    { 10, 6, 4, 20, 41.0m },
                    { 9, 7, 3, 40, 82.0m },
                    { 8, 6, 3, 30, 61.5m },
                    { 7, 5, 3, 20, 41.0m },
                    { 6, 6, 2, 40, 82.0m },
                    { 5, 5, 2, 30, 61.5m },
                    { 4, 4, 2, 20, 41.0m },
                    { 3, 5, 1, 40, 82.0m },
                    { 2, 4, 1, 30, 61.5m },
                    { 21, 2, 7, 40, 82.0m },
                    { 89, 6, 30, 30, 61.5m },
                    { 22, 1, 8, 20, 41.0m },
                    { 24, 3, 8, 40, 82.0m },
                    { 43, 8, 15, 20, 41.0m },
                    { 42, 9, 14, 40, 82.0m },
                    { 41, 8, 14, 30, 61.5m },
                    { 40, 7, 14, 20, 41.0m },
                    { 39, 8, 13, 40, 82.0m },
                    { 38, 7, 13, 30, 61.5m },
                    { 37, 6, 13, 20, 41.0m },
                    { 36, 7, 12, 40, 82.0m },
                    { 35, 6, 12, 30, 61.5m },
                    { 34, 5, 12, 20, 41.0m },
                    { 33, 6, 11, 40, 82.0m },
                    { 32, 5, 11, 30, 61.5m },
                    { 31, 4, 11, 20, 41.0m },
                    { 30, 5, 10, 40, 82.0m },
                    { 29, 4, 10, 30, 61.5m },
                    { 28, 3, 10, 20, 41.0m },
                    { 27, 4, 9, 40, 82.0m },
                    { 26, 3, 9, 30, 61.5m },
                    { 25, 2, 9, 20, 41.0m },
                    { 23, 2, 8, 30, 61.5m },
                    { 90, 7, 30, 40, 82.0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PurchaseOrderDetails",
                keyColumn: "PurchaseOrderDetailId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 30);
        }
    }
}
