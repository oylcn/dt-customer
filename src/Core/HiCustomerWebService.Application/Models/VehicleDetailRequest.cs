using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class VehicleDetailRequest
    {
        public long CitizenshipNumber { get; set; }
        public string PlateCityCode { get; set; }
        public string PlateNo { get; set; }

    }
}
