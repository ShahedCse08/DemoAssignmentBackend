using AutoMapper;
using Entities.DataTransferObjects.Creation;
using Entities.DataTransferObjects.Manipulator;
using Entities.Models.PurchaseOrders;

namespace Demo.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PurchaseOrderCreationDto, PurchaseOrder>();
            CreateMap<PurchaseOrderDetailCreationDto, PurchaseOrderDetail>();
            CreateMap<PurchaseOrderDetailUpdateDto, PurchaseOrderDetail>();
            CreateMap<PurchaseOrderUpdateDto, PurchaseOrder>();
            CreateMap<PurchaseOrderWithDetailsUpdateDto, PurchaseOrderDetail>();
        }
    }

}
