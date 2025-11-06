using Buildflow.Service.Service.InventoryMaterial;
using Microsoft.AspNetCore.Mvc;

namespace Buildflow.Api.Controllers.InventoryMaterial
{

        [Route("api/[controller]")]
        [ApiController]
        public class InventoryMaterialController : ControllerBase
        {
            private readonly IInventoryMaterialService _service;

            public InventoryMaterialController(IInventoryMaterialService service)
            {
                _service = service;
            }

            [HttpGet("status")]
            public async Task<IActionResult> GetMaterialStatus()
            {
                var result = await _service.GetMaterialStatusAsync();
                return Ok(result);
            }
        }
    
}

