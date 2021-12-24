using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class VehicleModelListResponse : BaseResponse
    {
        public VehicleModelListResponse() : base() { }

        public List<KeyValueInput> Models { get; set; }
    }
}
