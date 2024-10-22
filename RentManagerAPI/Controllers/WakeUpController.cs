using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WakeUpController : ControllerBase
    {
        /// <summary>
        /// Endpoint para verificar se a API está funcionando.
        /// </summary>
        /// <returns>200 - API está ativa.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("RentManagerAPI is active!");
        }
    }
}
