using Contracts.Interfaces.Domain.PurchaseOrders;
using Entities.Context;
using Entities.DataTransferObjects.Report;
using Entities.DataTransferObjects.Retrieve;
using Entities.Models;
using Entities.Models.PurchaseOrders;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Domain.PurchaseOrders
{
    public class PurchaseOrderRepository : RepositoryBase<PurchaseOrder>, IPurchaseOrderRepository
    {
        private readonly RepositoryContext _context;
        public PurchaseOrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }

        public async Task CreatePurchaseOrder(PurchaseOrder purchaseOrder, IEnumerable<PurchaseOrderDetail> purchaseOrderDetails)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    purchaseOrder = await CreateAndReturnAsync(purchaseOrder);

                    foreach (var purchaseOrderDetail in purchaseOrderDetails)
                    {
                        purchaseOrderDetail.PurchaseOrderId = purchaseOrder.PurchaseOrderId;
                        _context.Set<PurchaseOrderDetail>().Add(purchaseOrderDetail);
                    }

                    await _context.SaveChangesAsync(); // Assuming you're using Entity Framework Core
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    // Handle exception
                    throw;
                }
            }
        }

        public async Task UpdatePurchaseOrder(PurchaseOrder purchaseOrder, IEnumerable<PurchaseOrderDetail> purchaseOrderDetails)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {

                    Update(purchaseOrder);
                    var existingDetails = await _context.PurchaseOrderDetails
                                                        .Where(d => d.PurchaseOrderId == purchaseOrder.PurchaseOrderId)
                                                        .ToListAsync();
                    var detailsToAdd = purchaseOrderDetails.Where(d => d.PurchaseOrderDetailId == 0).ToList();
                    var detailsToUpdate = purchaseOrderDetails.Where(d => d.PurchaseOrderDetailId != 0).ToList();
                    var detailsToDelete = existingDetails.Where(d => !purchaseOrderDetails.Any(pod => pod.PurchaseOrderDetailId == d.PurchaseOrderDetailId)).ToList();
                    foreach (var detail in detailsToAdd)
                    {
                        detail.PurchaseOrderId = purchaseOrder.PurchaseOrderId;
                        _context.PurchaseOrderDetails.Add(detail);
                    }
                    foreach (var detail in detailsToUpdate)
                    {
                        var existingDetail = existingDetails.FirstOrDefault(d => d.PurchaseOrderDetailId == detail.PurchaseOrderDetailId);
                        if (existingDetail != null)
                        {
                            _context.Entry(existingDetail).CurrentValues.SetValues(detail);
                        }
                    }
                    _context.PurchaseOrderDetails.RemoveRange(detailsToDelete);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }


        public async Task<PagedList<PurchaseOrderDto>> GetPurchaseOrdersAsync(PurchaseOrderParameters purchaseOrderParameters, bool trackChanges)
        {

            var purchaseOrders = FindAll(trackChanges);
            var suppliers = _context.Suppliers;
            var query = from purchaseOrder in purchaseOrders
                        join supplier in suppliers on purchaseOrder.SupplierId equals supplier.SupplierId
                        select new PurchaseOrderDto
                        {
                            PurchaseOrderId = purchaseOrder.PurchaseOrderId,
                            ReferenceId = purchaseOrder.ReferenceId,
                            PurchaseOrderNumber = purchaseOrder.PurchaseOrderNumber,
                            PurchaseOrderDate = purchaseOrder.PurchaseOrderDate,
                            Supplier = supplier.Name,
                            ExpectedDate = purchaseOrder.ExpectedDate,
                            Remarks = purchaseOrder.Remarks,
                        };

            var result = await query.Search(purchaseOrderParameters.SearchTerm).ToListAsync();
            var pagedResult = PagedList<PurchaseOrderDto>.ToPagedList(result, purchaseOrderParameters.PageNumber,
            purchaseOrderParameters.PageSize);
            return pagedResult;

        }


        public async Task<PurchaseOrder> GetPurhcaseOrderDetailsAsync(int purchaseOrderId, bool trackChanges)
        {
            var result = await FindByCondition(c => c.PurchaseOrderId.Equals(purchaseOrderId), trackChanges)
                .Include(x => x.PurchaseOrderDetails)
                .SingleOrDefaultAsync();
            return result;
        }

        public async Task<PurchaseOrder> GetPurhcaseOrderAsync(int purchaseOrderId, bool trackChanges)
        {
            var result = await FindByCondition(c => c.PurchaseOrderId.Equals(purchaseOrderId), trackChanges)
                .SingleOrDefaultAsync();
            return result;
        }


        public async Task DeletePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var purchaseDetails = await _context.PurchaseOrderDetails
                              .Where(x => x.PurchaseOrderId == purchaseOrder.PurchaseOrderId)
                              .ToListAsync();

                    _context.PurchaseOrderDetails.RemoveRange(purchaseDetails);
                    Delete(purchaseOrder);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }

        public async Task<PurchaseOrderReportDto> GetPurchaseOrderReportDataSource(int purchaseOrderId)
        {

            var purchaseOrders = _context.PurchaseOrders.Where(x => x.PurchaseOrderId == purchaseOrderId);
            var suppliers = _context.Suppliers;
            var products = _context.Products;
            var purchaseOrderDetails = _context.PurchaseOrderDetails.Where(x => x.PurchaseOrderId == purchaseOrderId);
            var purchaseOrderDetailForMapping = new List<PurchaseOrderDetailReportDto>();

            if (purchaseOrderDetails != null && purchaseOrderDetails.Count() > 0)
            {
                purchaseOrderDetailForMapping = await (from detail in purchaseOrderDetails
                                                       join product in products on detail.LineItemId equals product.ProductId
                                                       select new PurchaseOrderDetailReportDto
                                                       {
                                                           LineItemName = product.Name,
                                                           Quantity = detail.Quantity,
                                                           Rate = detail.Rate
                                                       }).ToListAsync();
            }


            var query = from purchaseOrder in purchaseOrders
                        join supplier in suppliers on purchaseOrder.SupplierId equals supplier.SupplierId
                        select new PurchaseOrderReportDto
                        {
                            ReferenceId = purchaseOrder.ReferenceId,
                            PurchaseOrderNumber = purchaseOrder.PurchaseOrderNumber,
                            PurchaseOrderDate = purchaseOrder.PurchaseOrderDate,
                            Supplier = supplier.Name,
                            ExpectedDate = purchaseOrder.ExpectedDate,
                            Remarks = purchaseOrder.Remarks,
                            purchaseOrderDetails = purchaseOrderDetailForMapping
                        };

            var result = await query.FirstOrDefaultAsync();

            return result;

        }

        public async Task<bool> IsExixst(PurchaseOrder purchaseOrder)
        {
            var existingData = await _context.PurchaseOrders.Where(x => x.PurchaseOrderNumber == purchaseOrder.PurchaseOrderNumber
                || x.ReferenceId == purchaseOrder.ReferenceId).ToListAsync();
            if (existingData != null && existingData.Count > 0)
            {
                return true;

            }
            var isExist = (existingData != null && existingData.Count > 0) ? true : false;
            return isExist;

        }

        public async Task<PurchaseOrderForEditDto> GetPurchaseOrderByPurchaseId(int purchaseOrderId)
        {

            var purchaseOrders = _context.PurchaseOrders.Where(x => x.PurchaseOrderId == purchaseOrderId);
            var suppliers = _context.Suppliers;
            var products = _context.Products;
            var purchaseOrderDetails = _context.PurchaseOrderDetails.Where(x => x.PurchaseOrderId == purchaseOrderId);
            var purchaseOrderDetailForMapping = new List<PurchaseOrderDetailForEditDto>();

            if (purchaseOrderDetails != null && purchaseOrderDetails.Count() > 0)
            {
                purchaseOrderDetailForMapping = await (from detail in purchaseOrderDetails
                                                       join product in products on detail.LineItemId equals product.ProductId
                                                       select new PurchaseOrderDetailForEditDto
                                                       {
                                                           PurchaseOrderDetailId = detail.PurchaseOrderDetailId,
                                                           PurchaseOrderId = detail.PurchaseOrderId,
                                                           LineItemId = detail.LineItemId,
                                                           Quantity = detail.Quantity,
                                                           Rate = detail.Rate,
                                                           LineItemName = product.Name

                                                       }).ToListAsync();
            }


            var query = from purchaseOrder in purchaseOrders
                        select new PurchaseOrderForEditDto
                        {
                            PurchaseOrderId = purchaseOrder.PurchaseOrderId,
                            SupplierId = purchaseOrder.SupplierId,
                            ReferenceId = purchaseOrder.ReferenceId,
                            PurchaseOrderNumber = purchaseOrder.PurchaseOrderNumber,
                            PurchaseOrderDate = purchaseOrder.PurchaseOrderDate,
                            ExpectedDate = purchaseOrder.ExpectedDate,
                            Remarks = purchaseOrder.Remarks,
                            PurchaseOrderDetailForEditDtos = purchaseOrderDetailForMapping
                        };

            var result = await query.FirstOrDefaultAsync();

            return result;

        }

    }

}

