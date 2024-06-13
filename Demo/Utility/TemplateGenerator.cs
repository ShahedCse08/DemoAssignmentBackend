using Entities.DataTransferObjects.Report;
using Entities.Models.PurchaseOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString(PurchaseOrderReportDto purchaseOrderData)
        {
            var sb = new StringBuilder();
            sb.Append(@"
            <html>
                <head>
                    <style>
                        body { font-family: Arial, sans-serif; margin: 0; padding: 0; }
                        .header { text-align: center; font-size: 24px; margin-bottom: 10px; color: #4CAF50; }
                        .sub-header { text-align: center; font-size: 18px; margin-bottom: 10px; color: #555555; }
                        .summary-table, .details-table { width: 100%; border-collapse: collapse; margin-bottom: 20px; }
                        .summary-table td, .details-table th, .details-table td { padding: 10px; }
                        .summary-table td { border: none; }
                        .details-table th:nth-child(1), .details-table td:nth-child(1) { text-align: left; }
                        .details-table th:nth-child(n+2), .details-table td:nth-child(n+2) { text-align: right; }
                        .details-table th { background-color: #4CAF50; color: white; }
                        .details-table tr:nth-child(even) { background-color: #f2f2f2; }
                        .details-table tr:hover { background-color: #ddd; }
                        .total-row td { font-weight: bold; text-align: right; }
                    </style>
                </head>
                <body>
                    <div class='header'>Dependable Solutions Inc</div>
                    <div class='sub-header'>Purchase Order Report</div>
                    <table class='summary-table'>
                        <tr>
                            <td><strong>Ref. ID:</strong></td>
                            <td>" + purchaseOrderData.ReferenceId.ToString("D3") + @"</td>
                            <td><strong>PO No.:</strong></td>
                            <td>" + purchaseOrderData.PurchaseOrderNumber + @"</td>
                        </tr>
                        <tr>
                            <td><strong>Current Date:</strong></td>
                            <td>" + purchaseOrderData.PurchaseOrderDate.ToString("MMM dd, yyyy") + @"</td>
                            <td><strong>Supplier:</strong></td>
                            <td>" + purchaseOrderData.Supplier + @"</td>
                        </tr>
                        <tr>
                            <td><strong>Expected Date:</strong></td>
                            <td>" + purchaseOrderData.ExpectedDate.ToString("MMM dd, yyyy") + @"</td>
                            <td><strong>Remarks:</strong></td>
                            <td>" + purchaseOrderData.Remarks + @"</td>
                        </tr>
                    </table>
                    <table class='details-table'>
                        <tr>
                            <th>Item</th>
                            <th>Quantity</th>
                            <th>Rate($)</th>
                            <th>Cost($)</th>
                        </tr>");

            decimal totalCost = 0;
            foreach (var detail in purchaseOrderData.purchaseOrderDetails)
            {
                decimal cost = detail.Quantity * detail.Rate;
                totalCost += cost;
                sb.AppendFormat(@"
                        <tr>
                            <td>{0}</td>
                            <td>{1}</td>
                            <td>{2}</td>
                            <td>{3}</td>
                        </tr>", detail.LineItemName, detail.Quantity, detail.Rate, cost);
            }

            sb.AppendFormat(@"
                        <tr class='total-row'>
                            <td colspan='3'>Total Cost</td>
                            <td>{0}</td>
                        </tr>", totalCost);

            sb.Append(@"
                    </table>
                </body>
            </html>");

            return sb.ToString();
        }
    }
}
