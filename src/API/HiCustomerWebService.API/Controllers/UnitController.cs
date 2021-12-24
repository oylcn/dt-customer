using HiCustomerWebService.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace HiCustomerWebService.API.Controllers
{
    [Route("api/unit")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        [SwaggerOperation(Summary = "Kişi isim soyisim ve doğum tarihi bilgilerini döner.")]
        [HttpPost("person")]
        public async Task<ActionResult<PersonResponse>> GetPersonAsync([FromBody] PersonRequest request)
        {
            return Ok(await Task.FromResult(new PersonResponse()));
        }

        [SwaggerOperation(Summary = "Kişinin açık adres bilgisini döner.")]
        [HttpPost("person-address")]
        public async Task<ActionResult<AddressResponse>> GetPersonAddressAsync([FromBody]PersonRequest request)
        {
            return Ok(await Task.FromResult(new AddressResponse()));
        }

        [SwaggerOperation(Summary = "Meslek listesini getirir.")]
        [HttpGet("occupations")]
        public async Task<ActionResult<OccupationListResponse>> GetOccupationsAsync()
        {
            return Ok(await Task.FromResult(new OccupationListResponse()));
        }

        [SwaggerOperation(Summary = "Faaliyet listesini getirir.")]
        [HttpGet("corporate-activities")]
        public async Task<ActionResult<CorporateActivityListResponse>> GetCorporateActivitiesAsync()
        {
            return Ok(await Task.FromResult(new CorporateActivityListResponse()));
        }
    }
}
