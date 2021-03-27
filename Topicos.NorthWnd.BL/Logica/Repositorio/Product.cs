using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Repositorio
{
    internal class Product
    {
        private NorthWindContext _elContexto;

        public Product()
        {
                
        }
        public Product(NorthWindContext elContexto)
        {
            _elContexto = elContexto;
        }

        public IList<Model.Models.Product> QryAllProducts ()
        {
            var laConsulta = _elContexto.Products.ToList();
            return laConsulta;
        }


        public Model.Models.Product QryPorId(int elIdDeProducto)
        {
            var laConsulta = _elContexto.Products.Include(p => p.Category).Include(p=> p.Supplier).Where(p=> p.ProductId == elIdDeProducto).ToList().FirstOrDefault();
            return laConsulta;
        }

        public IList<Model.Models.Product> QryPorNombreAproximado(string elNombreDelProducto)
        {
            // IQueryable
            var laConsulta = _elContexto.Products.Where(p => p.ProductName.Contains(elNombreDelProducto));
            laConsulta = laConsulta.OrderByDescending(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public int Add(Model.Models.Product elProducto)
        {
            _elContexto.Products.Add(elProducto);
            _elContexto.SaveChanges();
            return elProducto.ProductId;
        }

        public IList<Model.Models.Product> QryPorNombreProveedorAproximado(string elNombreDelProveedor)
        {
            // IQueryable
            var laConsulta = _elContexto.Products.Include(p => p.Category).Include(p => p.Supplier).Where(p => p.Supplier.ContactName.Contains(elNombreDelProveedor));
            laConsulta = laConsulta.OrderByDescending(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior)
        {
            // IQueryable
            var laConsulta = _elContexto.Products.Where(p => p.UnitPrice >= limiteInferior && p.UnitPrice <= limiteSuperior);
            laConsulta = laConsulta.OrderBy(p => p.UnitPrice);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
    }
}
