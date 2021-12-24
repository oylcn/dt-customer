using HiCustomerWebService.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace HiCustomerWebService.API.Controllers
{
    [Route("api/proposal")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        [SwaggerOperation(Summary = "Teklif detay bilgilerini döndürür.")]
        [HttpPost("get-proposal-detail")]
        public async Task<ActionResult<ProposalDetailResponse>> GetProposalDetailAsync([FromBody] ProposalDetailRequest proposalDetailRequest)
        {
            return Ok(await Task.FromResult(new ProposalDetailResponse()));
        }

        [SwaggerOperation(Summary = "Aktif teklif listesini döndürür.")]
        [HttpGet("get-proposals")]
        public async Task<ActionResult<GetProposalListResponse>> GetProposalsAsync(long CitizenshipNumber)
        {
            return Ok(await Task.FromResult(new GetProposalListResponse()));
        }

        [SwaggerOperation(Summary = "Teklif oluşturup geriye teklif detayını döner.")]
        [HttpPost("create-proposal")]
        public async Task<ActionResult<CreateProposalResponse>> CreateProposalAsync([FromBody] CreateProposalRequest createProposalRequest)
        {
            return Ok(await Task.FromResult(new CreateProposalResponse()));
        }

        [SwaggerOperation(Summary = "Teklif onaylama işlemi yapılır.")]
        [HttpPost("confirm-proposal")]
        public async Task<ActionResult<ConfirmProposalResponse>> ConfirmProposalAsync(ConfirmProposalRequest confirmProposalRequest)
        {
            return Ok(await Task.FromResult(new ConfirmProposalResponse()));
        }

        [SwaggerOperation(Summary = "Poliçe basımını döner")]
        [HttpPost("printout")]
        public async Task<ActionResult<PrintoutResponse>> CreatePrintoutAsync(PrintoutRequest printoutRequest)
        {
            return Ok(await Task.FromResult(new PrintoutResponse()));
        }
    }
}
