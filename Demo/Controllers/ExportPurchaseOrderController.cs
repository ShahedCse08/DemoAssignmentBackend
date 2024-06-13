using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Utility;
using Contracts.Interfaces.Repository;

namespace Demo.Controllers
{
    [Route("api/export")]
    [ApiController]
    public class ExportPurchaseOrderController : ControllerBase
    {
        private IConverter _converter;
        private readonly IRepositoryManager _repository;
        public ExportPurchaseOrderController(IConverter converter, IRepositoryManager repository)
        {
            _converter = converter;
            _repository = repository;
        }



        [HttpGet]
        public async Task<IActionResult> ExportPurchaseOrder(int purchaseOrderId)
        {
            try
            {
                var purchaseOrderData = await _repository.PurchaseOrder.GetPurchaseOrderReportDataSource(purchaseOrderId);
                if (purchaseOrderData == null)
                {
                    return NotFound($"Purchase order with ID {purchaseOrderId} not found.");
                }
                var htmlContent = TemplateGenerator.GetHTMLString(purchaseOrderData);

                var globalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10 },
                    DocumentTitle = "PDF Report"
                };
                var objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = htmlContent,
                    WebSettings = { DefaultEncoding = "utf-8" },
                    HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                    FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
                };
                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };
                var file = _converter.Convert(pdf);
                return File(file, "application/pdf", "EmployeeReport.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while generating the PDF.");
            }
        }
    }
}
