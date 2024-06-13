using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Report
{
    public class PurchaseOrderReportDto
    {
        public int ReferenceId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public string Supplier { get; set; }
        public DateTime ExpectedDate { get; set; }
        public string Remarks { get; set; }
        public List<PurchaseOrderDetailReportDto> purchaseOrderDetails { get; set; }
    }
}
