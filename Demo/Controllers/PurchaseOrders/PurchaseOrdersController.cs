using AutoMapper;
using Contracts.Interfaces.Logger;
using Contracts.Interfaces.Repository;
using Entities.DataTransferObjects.Retrieve;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;
using Entities.Models;
using Entities.DataTransferObjects.Creation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Entities.Models.PurchaseOrders;
using System.Collections.Generic;
using Entities.DataTransferObjects.Manipulator;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers.PurchaseOrders
{
    [Route("api/purchaseorders")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public PurchaseOrdersController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPurchaseOrders([FromQuery] PurchaseOrderParameters purchaseOrderParameters)
        {
            var purchaseOrders = await _repository.PurchaseOrder.GetPurchaseOrdersAsync(purchaseOrderParameters, trackChanges: false);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(purchaseOrders.MetaData));
            return Ok(purchaseOrders);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePurchaseOrder([FromBody] PurchaseOrderWithDetailsCreationDto purchaseOrderWithDetails)
        {
            var purchaseOrderEntity = _mapper.Map<PurchaseOrder>(purchaseOrderWithDetails.PurchaseOrder);
            var isExist = await _repository.PurchaseOrder.IsExixst(purchaseOrderEntity);
            if (isExist)
            {
                return BadRequest("Duplicate PO No. or Ref.Id found");
            }
            var purchaseOrderDetailEntities = _mapper.Map<IEnumerable<PurchaseOrderDetail>>(purchaseOrderWithDetails.PurchaseOrderDetails);
            await _repository.PurchaseOrder.CreatePurchaseOrder(purchaseOrderEntity, purchaseOrderDetailEntities);
            return Ok("Purchase order created successfully.");
            //  var result = _repository.PurchaseOrder.CreatePurhcaseOrder(purchaseOrderEntity, purchaseOrderDetailEntity);

        }

        [HttpPut("{purchaseOrderId}")]
        public async Task<IActionResult> UpdatePurchaseOrder(int purchaseOrderId, [FromBody] PurchaseOrderWithDetailsUpdateDto purchaseOrderWithDetails)
        {
            if (purchaseOrderWithDetails == null)
            {
                return BadRequest("Purchase order update data is null.");
            }

            var purchaseOrderEntity = await _repository.PurchaseOrder.GetPurhcaseOrderAsync(purchaseOrderId, trackChanges: false);
            if (purchaseOrderEntity == null)
            {
                return NotFound($"Purchase order with ID {purchaseOrderId} not found.");
            }
            var purchaseOrder = _mapper.Map<PurchaseOrder>(purchaseOrderWithDetails.PurchaseOrder);
            var purchaseOrderDetail = _mapper.Map<IEnumerable<PurchaseOrderDetail>>(purchaseOrderWithDetails.PurchaseOrderDetails);
            await _repository.PurchaseOrder.UpdatePurchaseOrder(purchaseOrder, purchaseOrderDetail);
            return NoContent();
        }


        [HttpDelete("{purchaseOrderId}")]
        public async Task<IActionResult> DeletePurchaseOrder(int purchaseOrderId)
        {
            var purchaseOrderEntity = await _repository.PurchaseOrder.GetPurhcaseOrderAsync(purchaseOrderId, trackChanges: true);
            if (purchaseOrderEntity == null)
            {
                return NotFound($"Purchase order with ID {purchaseOrderId} not found.");
            }
            await _repository.PurchaseOrder.DeletePurchaseOrder(purchaseOrderEntity);
            return NoContent();

        }

        [HttpGet("{purchaseOrderId}")]
        public async Task<ActionResult<PurchaseOrderForEditDto>> GetPurchaseOrderByPurchaseId(int purchaseOrderId)
        {
                var purchaseOrder = await _repository.PurchaseOrder.GetPurchaseOrderByPurchaseId(purchaseOrderId);
                if (purchaseOrder == null)
                {
                    return NotFound();
                }
                return purchaseOrder;
        }
    }


}
