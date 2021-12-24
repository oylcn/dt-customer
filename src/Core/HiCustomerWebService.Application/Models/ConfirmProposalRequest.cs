using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class ConfirmProposalRequest
    {
        public long CitizenshipNumber { get; set; }
        public long ProposalNo { get; set; }
        public int InstallmentCount { get; set; }
        public List<KeyValueInput> Parameters { get; set; }
    }
}
