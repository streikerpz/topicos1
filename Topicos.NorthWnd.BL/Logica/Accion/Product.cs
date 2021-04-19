using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Accion
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

        public Model.Models.Product QryPorId(int elIdDeProducto)
        {
            var elRepositorio = new Logica.Repositorio.Product(_elContexto);
            var elResultado = elRepositorio.QryPorId(elIdDeProducto);
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorNombreAproximado(string elNombreDelProducto)
        {
            var elRepositorio = new Logica.Repositorio.Product(_elContexto);
            var elResultado = elRepositorio.QryPorNombreProveedorAproximado(elNombreDelProducto);
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior)
        {
            var elRepositorio = new Logica.Repositorio.Product(_elContexto);
            var elResultado = elRepositorio.QryPorRangoDePrecio(limiteInferior, limiteSuperior);
            return elResultado;
        }
        public IList<Model.Models.Product> QryPorNombreCategoriaAproximado (string elNombreDelProducto)
        {
            var elRepositorio = new Logica.Repositorio.Product(_elContexto);
            var elResultado = elRepositorio.QryPorCategoriaAproximado(elNombreDelProducto);
            return elResultado;
        }
        public IList<Model.Models.Product> QryPorNombreAproximadoConIntervalo(string elNombreDelProducto)
        {
            var elRepositorio = new Logica.Repositorio.Product(_elContexto);
            var elResultado = elRepositorio.QryPorNombreAproximadoConIntervalo(elNombreDelProducto);
            return elResultado;
        }
    }
}
