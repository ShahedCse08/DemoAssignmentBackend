﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.Retrieve
{
    public class PurchaseOrderForEditDto
    {
        public int PurchaseOrderId { get; set; }
        public int ReferenceId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public int SupplierId { get; set; }
        public DateTime ExpectedDate { get; set; }
        public string Remarks { get; set; }
        public List<PurchaseOrderDetailForEditDto> PurchaseOrderDetailForEditDtos { get; set; }
    }
}
