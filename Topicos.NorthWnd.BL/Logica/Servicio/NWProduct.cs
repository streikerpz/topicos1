using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.BL.Logica.Interface;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Servicio
{
    public class NWProduct : IProduct
    {
        private NorthWindContext _elContexto;

        public NWProduct()
        {
            _elContexto = new Model.Models.NorthWindContext();
        }

        public NWProduct(NorthWindContext elContexto)
        {
            _elContexto = elContexto;
        }
        public Product QryPorId(int elIdDeProducto)
        {
            var laAccion = new Logica.Accion.Product(_elContexto);
            var elResultado = laAccion.QryPorId(elIdDeProducto);
            return elResultado;
        }

        public IList<Product> QryPorNombreAproximado(string elNombreDelProducto)
        {
            var laAccion = new Logica.Accion.Product(_elContexto);
            var elResultado = laAccion.QryPorNombreAproximado(elNombreDelProducto);
            return elResultado;
        }

        public IList<Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior)
        {
            var laAccion = new Logica.Accion.Product(_elContexto);
            var elResultado = laAccion.QryPorRangoDePrecio(limiteInferior, limiteSuperior);
            return elResultado;
        }

        public IList<Product> QryPorNombreCategoriaAproximado(string elNombreDelProducto)
        {
            var laAccion = new Logica.Accion.Product(_elContexto);
            var elResultado = laAccion.QryPorNombreCategoriaAproximado(elNombreDelProducto);
            return elResultado;
        }
        public IList<Product> QryPorNombreAproximadoConIntervalo(string elNombreDelProducto)
        {
            var laAccion = new Logica.Accion.Product(_elContexto);
            var elResultado = laAccion.QryPorNombreAproximadoConIntervalo(elNombreDelProducto);
            return elResultado;
        }
    }
}
