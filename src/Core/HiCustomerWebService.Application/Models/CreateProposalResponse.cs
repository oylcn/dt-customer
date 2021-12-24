using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class CreateProposalResponse : BaseResponse
    {
        public CreateProposalResponse() : base() { }

        public long ProposalNo { get; set; }
        public string ProposalBeginDate { get; set; }
        public string ProposalEndDate { get; set; }
        public List<CoverOutput> Covers { get; set; }
        public List<QuestionOutput> Questions { get; set; }

    }

    public class CoverOutput
    {
        public int Code { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public decimal Premium { get; set; }
    }

    public class QuestionOutput
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Answer { get; set; }
    }
}
