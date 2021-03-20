using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
            var elResultado = elServicio.QryAllProducts();
            return Ok(elResultado);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
            var elResultado = elServicio.QryPorId(id);
            if (elResultado != null)
                return Ok(elResultado);
            else
            {
                return NotFound();
            }
        }
    }
}
