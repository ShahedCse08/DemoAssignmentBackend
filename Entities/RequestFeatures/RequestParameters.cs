
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.RequestFeatures
{
    public abstract class RequestParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

        public string OrderBy { get; set; }
        public string Fields { get; set; }
    }

    public class PurchaseOrderParameters : RequestParameters
    {
        public PurchaseOrderParameters()
        {
            OrderBy = "purchaseorderdate";
        }
        public string SearchTerm { get; set; }

    }
    
}
