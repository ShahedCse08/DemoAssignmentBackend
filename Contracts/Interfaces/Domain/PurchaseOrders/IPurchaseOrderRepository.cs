using Entities.DataTransferObjects.Report;
using Entities.DataTransferObjects.Retrieve;
using Entities.Models;
using Entities.Models.PurchaseOrders;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces.Domain.PurchaseOrders
{
    public interface IPurchaseOrderRepository
    {
        Task CreatePurchaseOrder(PurchaseOrder purchaseOrder, IEnumerable<PurchaseOrderDetail> purchaseOrderDetail);
        Task<PagedList<PurchaseOrderDto>> GetPurchaseOrdersAsync(PurchaseOrderParameters purchaseOrderParameters, bool trackChanges);
        Task UpdatePurchaseOrder(PurchaseOrder purchaseOrder, IEnumerable<PurchaseOrderDetail> purchaseOrderDetails);
        Task DeletePurchaseOrder(PurchaseOrder purchaseOrder);
        Task<PurchaseOrder> GetPurhcaseOrderDetailsAsync(int purchaseOrderId, bool trackChanges);

        Task<PurchaseOrderReportDto> GetPurchaseOrderReportDataSource(int purchaseOrderId);
        Task<PurchaseOrder> GetPurhcaseOrderAsync(int purchaseOrderId, bool trackChanges);

        Task<bool> IsExixst(PurchaseOrder purchaseOrder);

        Task<PurchaseOrderForEditDto> GetPurchaseOrderByPurchaseId(int purchaseOrderId);
    }
}
