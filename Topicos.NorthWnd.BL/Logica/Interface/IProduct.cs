using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Interface
{
    public interface IProduct
    {
        Product QryPorId(int elIdDeProducto);

        IList <Product> QryPorNombreAproximado(string elNombreDelProducto);

        IList<Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior);

        IList<Product> QryPorNombreCategoriaAproximado(string elNombreDeLaCategoria);
        IList<Product> QryPorNombreAproximadoConIntervalo(string elNombreDeLaCategoria);

    }
}
