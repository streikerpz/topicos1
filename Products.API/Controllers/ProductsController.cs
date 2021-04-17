using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Products.API.ViewModels;
using System;
using System.Collections.Generic;
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

        [HttpPut("{id}")]
        public IActionResult PutProduct (int id, [FromBody]Topicos.NorthWnd.Model.Models.Product elProducto)
        {
            if (id == elProducto.ProductId)
            {
                var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
                var pudoActualizarElRegistro = elServicio.ActualizarTodoElProducto(id, elProducto);
                if (pudoActualizarElRegistro)
                    return NoContent();
                else
                    return NotFound();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPatch("{id}")]
        public IActionResult PatchProduct(int id, [FromBody] JsonPatchDocument<ProductUpdate> parchesAlProducto)
        {
            var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
            var elResultadoRecibido = elServicio.QryPorId(id);
            if (elResultadoRecibido != null)
            {
                //var elResultadoDevuelto = _mapper.Map<Products.API.ViewModels.ProductQry>(elResultadoRecibido);
                return ActualizarProductoParcialmente (elResultadoRecibido, parchesAlProducto);
            }
            else
            {
                return NotFound();
            }
        }

        private IActionResult ActualizarProductoParcialmente(Topicos.NorthWnd.Model.Models.Product elResultadoRecibido, JsonPatchDocument<ProductUpdate> parchesAlProducto)
        {
            var elProductoParaParchar = new ProductUpdate()
            {
                ProductId = elResultadoRecibido.ProductId,
                ProductName = elResultadoRecibido.ProductName,
                UnitPrice = elResultadoRecibido.UnitPrice,
                Discontinued = elResultadoRecibido.Discontinued
            };
            parchesAlProducto.ApplyTo(elProductoParaParchar);

            throw new NotImplementedException();
        }
    }
}
