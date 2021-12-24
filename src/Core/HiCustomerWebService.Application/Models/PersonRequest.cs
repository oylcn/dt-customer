using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class PersonRequest
    {
        public long CitizenshipNumber { get; set; }
        public string BirthDate { get; set; }
    }
}
