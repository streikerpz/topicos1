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
                     case 4:
                        RaizCuadrada();
                        break;
                    case 5:
                        Tangente();
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
        
        private void Tangente()
    {
     Console.WriteLine("Operación Tangente");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite el número: ");
            var x = ObtenerNumero();
         
    double angle;
    double radians;
    double result;

// Calcula la tangente de x grados.
    angle = (double)x;
    radians = angle * (Math.PI/180);
    result = Math.Tan(radians);
    Console.WriteLine("The tangent of 30 degrees is {0}.", result);


    }
        
        
        
        private void RaizCuadrada()
        {
        Console.WriteLine("Operación de Raizcuadrada");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite número: ");
            var x = ObtenerNumero();
           
      int num = (double)x;
      double result = Math.Sqrt(num);
      Console.WriteLine(result);
         }
  }
   

  
} 
        
        
        private void Potencia()
        {
        Console.WriteLine("Operación Potencia");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite número: ");
            var x = ObtenerNumero();
    
        int numero = (double)x;
        double elevadoAlCuadrado = Math.Pow(numero, 2); // Elevarlo a la potencia 2
        Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", numero, elevadoAlCuadrado));
    
        }

        private void Logaritmo()
   {
       Console.WriteLine("Operación de Logaritmo");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite número: ");
            var x = ObtenerNumero();


      var double[] x = { x };

      foreach (double argX in x)
      {
         //Encuentre el logaritmo natural de argX.
         Console.WriteLine("                      Math.Log({0}) = {1:E16}",
                           argX, Math.Log(argX));

         //Evaluar 1 / log [X] (e).
         Console.WriteLine("             1.0 / Math.Log(e, {0}) = {1:E16}",
                           argX, 1.0 / Math.Log(Math.E, argX));
         Console.WriteLine();
      }
   }
}

    
}


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

        private void MostrarMenuPrincipal()
        {
            Console.WriteLine("Opciones principales");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Suma.");
            Console.WriteLine("2. Logaritmo.");
            Console.WriteLine("3. Potencia.");
            Console.WriteLine("4. Tangente.");
            Console.WriteLine("5. Raíz cuadrada.");
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
