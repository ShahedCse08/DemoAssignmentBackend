using Entities.Models.PurchaseOrders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces.Domain.PurchaseOrders
{
    public interface IPurchaseOrderDetailRepository
    {
        void DeletePurchaseOrderDetail(PurchaseOrderDetail purchaseOrderDetail);
        void BulkDeletePurchaseOrderDetail(IEnumerable<PurchaseOrderDetail> purchaseOrderDetails);
    }
}
