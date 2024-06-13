using Contracts.Interfaces.Domain;
using Contracts.Interfaces.Domain.PurchaseOrders;
using Contracts.Interfaces.Repository;
using Contracts.Interfaces.Utility;
using Entities.Context;
using Repository.Domain;
using Repository.Domain.PurchaseOrders;
using Repository.Utility;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IProductRepository _productRepository;
        private IDropdownRepository _dropdownRepository;
        private IAutoCompleteRepository _autoCompleteRepository;
        private IPurchaseOrderRepository _purchaseOrderRepository;
        private IPurchaseOrderDetailRepository _purchaseOrderDetailRepository;
        public RepositoryManager(RepositoryContext repositoryContext) {
            _repositoryContext  = repositoryContext;
        }
        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_repositoryContext);
                return _productRepository;
            }
        }
        public IPurchaseOrderRepository PurchaseOrder
        {
            get
            {
                if (_purchaseOrderRepository == null)
                    _purchaseOrderRepository = new PurchaseOrderRepository(_repositoryContext);
                return _purchaseOrderRepository;
            }
        }
        public IPurchaseOrderDetailRepository PurchaseOrderDetail
        {
            get
            {
                if (_purchaseOrderDetailRepository == null)
                    _purchaseOrderDetailRepository = new PurchaseOrderDetailRepository(_repositoryContext);
                return _purchaseOrderDetailRepository;
            }
        }
        public IDropdownRepository Dropdown
        {
            get
            {
                if (_dropdownRepository == null)
                    _dropdownRepository = new DropdownRepository(_repositoryContext);
                return _dropdownRepository;
            }
        }
        public IAutoCompleteRepository AutoComplete
        {
            get
            {
                if (_autoCompleteRepository == null)
                    _autoCompleteRepository = new AutoCompleteRepository(_repositoryContext);
                return _autoCompleteRepository;
            }
        }
        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();

    }
}
