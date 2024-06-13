using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Retrieve
{
    public class PurchaseOrderDetailForEditDto
    {
        public int PurchaseOrderDetailId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int LineItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public string LineItemName { get; set; }
    }
}
