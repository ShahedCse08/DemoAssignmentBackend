using Entities.Models.PurchaseOrders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Report
{
    public class PurchaseOrderDetailReportDto
    {
        public string LineItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}
