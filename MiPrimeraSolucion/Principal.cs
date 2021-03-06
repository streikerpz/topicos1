using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimeraSolucion
{
    public class Principal
    {
        public void ElMetodoPrincipal()
        {
            MostrarMenuPrincipal();
            var laOpcion = ObtenerOpcion();
            InvocarLaOpcionCorrespondiente(laOpcion);
        }

        private void InvocarLaOpcionCorrespondiente(int? laOpcion)
        {
            if (laOpcion != null)
            {
                switch (laOpcion)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Logaritmo();
                        break;
                    case 3:
                        Potencia();
                        break;
                    case 7:
                        QryPorId();
                        break;
                    case 9:
                        QryPorNombreProveedor();
                        break;
                    case 0:
                        Terminar();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Terminar()
        {
            throw new NotImplementedException();
        }

        private void Potencia()
        {
            throw new NotImplementedException();
        }

        private void Logaritmo()
        {
            throw new NotImplementedException();
        }

        private void Suma()
        {
            Console.WriteLine("Operación de Suma");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite el primer número: ");
            var x = ObtenerNumero();
            Console.WriteLine("Digite el segundo número: ");
            var y = ObtenerNumero();
            if (x != null && y != null)
            {
                var a = (double)x;
                var b = (double)y;
                var elServicio = new Calculadora.BL.MiCalculadora();
                var elResultado = elServicio.Suma(a, b);
                //Console.WriteLine(string.Format("Operación completada.  El resultado es [{0}]", elResultado.ToString()));
                Console.WriteLine($"Operación completada.  El resultado es [{elResultado}]" );
            }
            else
            {
                Console.WriteLine("Ocurrió un error al convertir los argumentos a números. Por favor revise.");
            }
        }

        private void ImprimirListaDeProductos(IList <Topicos.NorthWnd.Model.Models.Product> laListaDeProductos)
        {
            foreach (var item in laListaDeProductos)
            {
                ImprimirProducto(item);
            }
        }

        private void ImprimirProducto (Topicos.NorthWnd.Model.Models.Product elProducto)
        {
            Console.WriteLine($"Id : {elProducto.ProductId}. Nombre : {elProducto.ProductName}. Precio unitario : {elProducto.UnitPrice}. Unidades desabastecidas: {elProducto.UnitsUnderStock}.");
        }

        private void QryPorId()
        {
            Console.WriteLine("Consulta de producto por Id.");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite el código de producto: ");
            var x = ObtenerNumero();
            if (x != null)
            {
                int a = 0;
                try
                {
                    a = (int)x;
                    var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
                    var elResultado = elServicio.QryPorId(a);
                    if (elResultado != null)
                    {
                        ImprimirProducto(elResultado);
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró el producto con id {a}. Por favor revise.");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Ocurrió un error al convertir los argumentos a números. Por favor revise.");
                }
            }
            else
            {
                Console.WriteLine("Ocurrió un error al convertir los argumentos a números. Por favor revise.");
            }
        }

        private void QryPorNombreProveedor()
        {
            Console.WriteLine("Consulta de producto por nombre del proveedor.");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite el nombre del proveedor: ");
            var x = ObtenerHilera();
            if (x != null)
            {
                var elServicio = new Topicos.NorthWnd.BL.Logica.Servicio.NWProduct();
                var elResultado = elServicio.QryPorNombreAproximado(x);
                if (elResultado != null && elResultado.Count > 0)
                {
                    ImprimirListaDeProductos(elResultado);
                }
                else
                {
                    Console.WriteLine($"No se encontró el producto con nombre de proveedor {x}. Por favor revise.");
                }

            }
            else
            {
                    Console.WriteLine("Ocurrió un error al obtener el nombre del proveedor. Por favor revise.");
            }
}

        private void MostrarMenuPrincipal()
        {
            Console.WriteLine("Opciones principales");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Suma.");
            Console.WriteLine("2. Logaritmo.");
            Console.WriteLine("3. Potencia.");
            Console.WriteLine("4. Tangente.");
            Console.WriteLine("5. Raíz cuadrada.");
            Console.WriteLine("6. Suma siempre positiva.");
            Console.WriteLine("--------------------");
            Console.WriteLine("7. Consulta de producto por Id.");
            Console.WriteLine("8. Consulta de productos por nombre aproximado.");
            Console.WriteLine("9. Consulta de productos por nombre aproximado del proveedor.");
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Salir.");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite su opción: ");
        }

        private int? ObtenerOpcion()
        {
            string opcion = CapturarOpcion();
            int? resultado = ConvertirOpcionANumero(opcion);
            return resultado;
        }

        private string ObtenerHilera()
        {
            string opcion = CapturarOpcion();
            return opcion;
        }

        private static int? ConvertirOpcionANumero(string opcion)
        {
            int? resultado = null;
            int numeroConvertido;
            if (int.TryParse(opcion, out numeroConvertido))
            {
                resultado = numeroConvertido;
            }

            return resultado;
        }

        private string CapturarOpcion()
        {
            var opcion = string.Empty;
            opcion = Console.ReadLine();
            return opcion;
        }

        private double? ObtenerNumero()
        {
            string opcion = CapturarOpcion();
            double? resultado = ConvertirOpcionADouble(opcion);
            return resultado;
        }

        private static double? ConvertirOpcionADouble(string opcion)
        {
            double? resultado = null;
            double numeroConvertido;
            if (double.TryParse(opcion, out numeroConvertido))
            {
                resultado = numeroConvertido;
            }
            return resultado;
        }
    }
}
