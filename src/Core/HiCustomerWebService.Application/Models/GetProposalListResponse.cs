using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class GetProposalListResponse : BaseResponse
    {
        public GetProposalListResponse() : base() { }

        public List<CreateProposalResponse> Proposals { get; set; }
    }
}
