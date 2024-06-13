using Entities.Models.PurchaseOrders;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class PurchaseOrderDetailConfiguration : IEntityTypeConfiguration<PurchaseOrderDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderDetail> builder)
        {
            var purchaseOrderDetails = new List<PurchaseOrderDetail>();
            int detailId = 1;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    purchaseOrderDetails.Add(new PurchaseOrderDetail
                    {
                        PurchaseOrderDetailId = detailId,
                        PurchaseOrderId = i,
                        LineItemId = ((i + j) % 9) + 1, // Use ProductId from 1 to 9
                        Quantity = (j + 1) * 10,
                        Rate = (decimal)(j + 1) * 20.5m
                    });
                    detailId++;
                }
            }

            builder.HasData(purchaseOrderDetails);
        }
    }
}
