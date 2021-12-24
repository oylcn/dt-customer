using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class VehicleBrandListResponse : BaseResponse
    {
        public VehicleBrandListResponse() : base() { }

        public List<KeyValueInput> Brands { get; set; }
    }
}
