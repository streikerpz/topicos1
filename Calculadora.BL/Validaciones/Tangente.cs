using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.BL.Validaciones
{
    public class Tangente
    {
        public bool EstaDefinida (double cantidadDeGrados)
        {
            var resultado = Math.Abs(cantidadDeGrados % 180) != 90;
            return resultado;
        }

        /// <summary>
        /// Devuelve la tangente de un número. Cuando el número es de la forma (2n+1)pi/2, devuelve null
        /// </summary>
        /// <param name="cantidadDeGrados">Cantidad de grados</param>
        /// <returns>La tangente del número</returns>
        public double? RealizarCalculo (double cantidadDeGrados)
        {
            double? resultado = null;
            if (EstaDefinida (cantidadDeGrados))
                resultado =  (Math.Tan(cantidadDeGrados));
            return resultado;
        }
    }
}
