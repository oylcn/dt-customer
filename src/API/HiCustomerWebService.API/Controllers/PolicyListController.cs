using HiCustomerWebService.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace HiCustomerWebService.API.Controllers
{
    [Route("api/policies")]
    [ApiController]
    public class PolicyListController : ControllerBase
    {
        [SwaggerOperation(Summary = "Sisteme giriş yapan kullanıcının poliçelerini döndürür.")]
        [HttpGet]
        public async Task<ActionResult<GetPolicyListResponse>> GetPoliciesAsync(long citizenshipNumber)
        {
            return Ok(await Task.FromResult(new GetPolicyListResponse()));
        }
    }
}
