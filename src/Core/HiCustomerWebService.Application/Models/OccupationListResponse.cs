using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class OccupationListResponse : BaseResponse
    {
        public OccupationListResponse() : base()
        {
        }
        public List<KeyValueInput> Occupations { get; set; }
    }
}
