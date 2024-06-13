using Contracts.Interfaces.Domain.PurchaseOrders;
using Entities.Context;
using Entities.Models.PurchaseOrders;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Domain.PurchaseOrders
{
    public class PurchaseOrderDetailRepository : RepositoryBase<PurchaseOrderDetail>, IPurchaseOrderDetailRepository
    {
        private readonly RepositoryContext _context;
        public PurchaseOrderDetailRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
        public void DeletePurchaseOrderDetail(PurchaseOrderDetail purchaseOrderDetail) => Delete(purchaseOrderDetail);
        public void BulkDeletePurchaseOrderDetail(IEnumerable<PurchaseOrderDetail> purchaseOrderDetails) => BulkDelete(purchaseOrderDetails);


        
    }
}
