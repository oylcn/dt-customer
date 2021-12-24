using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class VehicleUsageCodeListResponse : BaseResponse
    {
        public VehicleUsageCodeListResponse() : base() { }
        public List<KeyValueInput> UsageCodes { get; set; }
    }
}
