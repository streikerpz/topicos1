using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Interface
{
    public interface IEmployee
    {
        IList <Employee> QryPorNombreJefatura(string NombreJefatura);

        IList<Employee> QryPorRangoDeEdad(decimal limiteInferior, decimal limiteSuperior);
        IList<Employee> QryPorRangoDeAntiguedad(decimal limiteInferior, decimal limiteSuperior);

        IList<Employee> QryPorDescripcionTerritorial(string descripcionTerritorio);

        IList<Employee> QryPorNombreEmpleado(string NombreEmpleado);
    }
}
