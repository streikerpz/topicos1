using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Products.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
            var elResultadoRecibido = elServicio.QryAllProducts();
            var elResultadoDevuelto = _mapper.Map<IList<Topicos.NorthWnd.Model.Models.Product>, IList<Products.API.ViewModels.ProductQry>>(elResultadoRecibido);
            return Ok(elResultadoDevuelto);
                //elResultado);
        }


        [Route("GetProduct", Name = "GetProduct")]
        public IActionResult GetProduct([System.Web.Http.FromUri] int id)
        {
            var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
            var elResultadoRecibido = elServicio.QryPorId(id);
            if (elResultadoRecibido != null)
            {
                var elResultadoDevuelto = _mapper.Map<Products.API.ViewModels.ProductQry>(elResultadoRecibido);
                return Ok(elResultadoDevuelto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreateProduct ([FromBody] ProductInsert elProducto)
        {
            var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
            var elProductoParaInsertar = _mapper.Map<Topicos.NorthWnd.Model.Models.Product>(elProducto);
            var elIdRecibido = elServicio.Add(elProductoParaInsertar);
            return CreatedAtRoute("GetProduct",
                new
                {
                    id = elIdRecibido
                }, elProductoParaInsertar);
        }
    }
}
