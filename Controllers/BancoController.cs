using BancoGraphql.Services;
using Microsoft.AspNetCore.Mvc;

namespace BancoGraphql.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly BancoService _bancoService;
        public BancoController(BancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet]
        public IActionResult GetAllBancos()
        {
            return new ObjectResult(_bancoService.GetAllBancos());
        }

        [HttpGet("{id}")]
        public IActionResult GetBancoById(int id)
        { 
            return new ObjectResult(_bancoService.GetBancoById(id));
        }

        [HttpGet("{id}/produtos")]
        public IActionResult GetAllProdutosByBancoID(int id)
        {
            return new ObjectResult(_bancoService.GetAllProdutosByBancoID(id));
        }
    }
}
