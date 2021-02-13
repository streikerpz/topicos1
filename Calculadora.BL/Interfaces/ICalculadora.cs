using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.BL
{
    public interface ICalculadora
    {
        double Potencia(double x, double y);

        double Logaritmo(double x);

        double Suma(double x, double y);

        double Tangente(double x);

        double RaizCuadrada(double x);
    }
}
