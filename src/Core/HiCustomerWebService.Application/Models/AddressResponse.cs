using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCustomerWebService.Application.Models
{
    public class AddressResponse : BaseResponse
    {
        public AddressResponse() : base() {}
        
        public List<KeyValueInput> AddressInputs { get; set; }
    }

    public class KeyValueInput
    {
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
