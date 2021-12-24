using HiCustomerWebService.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace HiCustomerWebService.API.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        [SwaggerOperation(Summary = "Araç detaylarını döndürür")]
        [HttpGet("vehicle-detail")]
        public async Task<ActionResult<VehicleDetailResponse>> GetVehicleDetailAsync(VehicleDetailRequest request)
        {
            return Ok(await Task.FromResult(new VehicleDetailResponse()));
        }

        [SwaggerOperation(Summary = "Araç markalarının listesini getirir.")]
        [HttpGet("vehicle-brands")]
        public async Task<ActionResult<VehicleBrandListResponse>> GetVehicleBrandsAsync(VehicleBrandListRequest vehiclebrandListRequest)
        {
            return Ok(await Task.FromResult(new VehicleBrandListResponse()));
        }

        [SwaggerOperation(Summary = "Seçilen markanın modellerini getirir.")]
        [HttpGet("vehicle-models")]
        public async Task<ActionResult<VehicleModelListResponse>> GetVehicleModelsAsync(VehicleModelListRequest vehicleModelListRequest)
        {
            return Ok(await Task.FromResult(new VehicleModelListResponse()));
        }

        [SwaggerOperation(Summary = "Araç kullanım tiplerini getirir.")]
        [HttpGet("vehicle-usage-codes")]
        public async Task<ActionResult<VehicleUsageCodeListResponse>> GetVehicleUsageCodesAsync(VehicleUsageCodeListRequest vehicleUsageCodeListRequest)
        {
            return Ok(await Task.FromResult(new VehicleUsageCodeListResponse()));
        }
    }
}
