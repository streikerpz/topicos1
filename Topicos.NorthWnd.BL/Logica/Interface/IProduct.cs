using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Interface
{
    public interface IProduct
    {
        Product QryPorId(int elIdDeProducto);

        IList<Model.Models.Product> QryAllProducts();

        IList<Product> QryPorNombreAproximado(string elNombreDelProducto);

        IList<Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior);

    }
}
