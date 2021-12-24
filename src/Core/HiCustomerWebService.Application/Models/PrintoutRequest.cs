using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class PrintoutRequest
    {
        public long CitizenshipNumber { get; set; }
        public long PolicyNo { get; set; }
        public int ProductNo { get; set; }
        public int RenewalNo { get; set; }
        public int Type { get; set; }
    }
}
