using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class GetPolicyListResponse : BaseResponse
    {
        public GetPolicyListResponse() : base() { }

        public List<CreateProposalResponse> Proposals { get; set; }
    }
}
