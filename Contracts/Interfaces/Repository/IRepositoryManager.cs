using Contracts.Interfaces.Domain;
using Contracts.Interfaces.Domain.PurchaseOrders;
using Contracts.Interfaces.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces.Repository
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IPurchaseOrderRepository PurchaseOrder { get; }
        IPurchaseOrderDetailRepository PurchaseOrderDetail { get; }
        IDropdownRepository Dropdown { get; }
        IAutoCompleteRepository AutoComplete { get; }
        Task SaveAsync();
    }
}
