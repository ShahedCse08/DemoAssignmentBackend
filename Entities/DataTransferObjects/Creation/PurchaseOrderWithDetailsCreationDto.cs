using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Creation
{
    public class PurchaseOrderWithDetailsCreationDto
    {
        public PurchaseOrderCreationDto PurchaseOrder { get; set; }
        public IEnumerable<PurchaseOrderDetailCreationDto> PurchaseOrderDetails { get; set; }
    }
}
