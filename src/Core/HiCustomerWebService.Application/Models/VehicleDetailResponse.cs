using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class VehicleDetailResponse : BaseResponse
    {
        public VehicleDetailResponse() : base() { }

        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public string TescilTarihi { get; set; }
        public bool IsRenewable { get; set; }
    }
}
