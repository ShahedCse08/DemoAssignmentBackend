using Entities.Models.PurchaseOrders;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {
            var purchaseOrders = new List<PurchaseOrder>();

            for (int i = 1; i <= 30; i++)
            {
                purchaseOrders.Add(new PurchaseOrder
                {
                    PurchaseOrderId = i,
                    ReferenceId = i,
                    PurchaseOrderNumber = $"PO{i:000}",
                    PurchaseOrderDate = DateTime.Now.AddDays(-i),
                    SupplierId = (i % 3) + 1, // Alternate between SupplierId 1, 2, and 3
                    ExpectedDate = DateTime.Now.AddDays(10),
                    Remarks = $"Remark {i}"
                });
            }

            builder.HasData(purchaseOrders);
        }
    }
}
