using System;

namespace Calculadora.BL
{
    public class MiCalculadora : ICalculadora
    {
        public double Logaritmo(double x)
        {
            var laEspecificacion = new Especificacion.Calculadora();
            var elResultado = laEspecificacion.Logaritmo(x);
            return elResultado;
        }

        public double Potencia(double x, double y)
        {
            var laEspecificacion = new Especificacion.Calculadora();
            var elResultado = laEspecificacion.Potencia(x, y);
            return elResultado;
        }

        public double RaizCuadrada(double x)
        {
            var laEspecificacion = new Especificacion.Calculadora();
            var elResultado = laEspecificacion.RaizCuadrada(x);
            return elResultado;
        }

        public double Suma(double x, double y)
        {
            var laEspecificacion = new Especificacion.Calculadora();
            var elResultado = laEspecificacion.Suma(x, y);
            return elResultado;
        }

        public double Tangente(double x)
        {
            var laEspecificacion = new Especificacion.Calculadora();
            var elResultado = laEspecificacion.Tangente(x);
            return elResultado;
        }
    }
}
