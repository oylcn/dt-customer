using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class CreateProposalRequest
    {
        public int ProductCode { get; set; }
        public long CitizenshipNumber { get; set; }
        public string GsmNo{ get; set; }
        public string Email { get; set; }
        public string PlateCityCode { get; set; }
        public string PlateNo { get; set; }
        public string EgmTescilNo { get; set; }
        public List<KeyValueInput> Parameters{ get; set; }
    }
}
