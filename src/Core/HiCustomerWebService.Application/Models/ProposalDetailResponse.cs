﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class ProposalDetailResponse : BaseResponse
    {
        public ProposalDetailResponse() : base() { }

        public CreateProposalResponse ProposalDetail { get; set; }
    }
}