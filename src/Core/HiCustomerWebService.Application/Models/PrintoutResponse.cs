using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class PrintoutResponse : BaseResponse
    {
        public PrintoutResponse() : base() { }

        public string PrintUrl { get; set; }

    }
}
