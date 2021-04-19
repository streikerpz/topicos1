using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.BL.Logica.Interface;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Servicio
{
    public class NWEmployee : IEmployee
    {
        private NorthWindContext _elContexto;

        public NWEmployee()
        {
            _elContexto = new Model.Models.NorthWindContext();
        }

        public NWEmployee(NorthWindContext elContexto)
        {
            _elContexto = elContexto;
        }


        public IList<Employee> QryPorNombreJefatura(string elNombreJefatura)
        {
            var laAccion = new Logica.Accion.Employee(_elContexto);
            var elResultado = laAccion.QryPorNombreJefatura(elNombreJefatura);
            return elResultado;
        }

        public IList<Employee> QryPorRangoDeEdad(decimal limiteInferior, decimal limiteSuperior)
        {
            var laAccion = new Logica.Accion.Employee(_elContexto);
            var elResultado = laAccion.QryPorRangoDeEdad(limiteInferior, limiteSuperior);
            return elResultado;
        }
        public IList<Employee> QryPorRangoDeAntiguedad(decimal limiteInferior, decimal limiteSuperior)
        {
            var laAccion = new Logica.Accion.Employee(_elContexto);
            var elResultado = laAccion.QryPorRangoDeEdad(limiteInferior, limiteSuperior);
            return elResultado;
        }

        public IList<Employee> QryPorDescripcionTerritorial(string descripcionTerritorio)
        {
            var laAccion = new Logica.Accion.Employee(_elContexto);
            var elResultado = laAccion.QryPorDescripcionTerritorial(descripcionTerritorio);
            return elResultado;
        }

        public IList<Employee> QryPorNombreEmpleado(string nombreEmpleado)
        {
            var laAccion = new Logica.Accion.Employee(_elContexto);
            var elResultado = laAccion.QryPorNombreEmpleado(nombreEmpleado);
            return elResultado;
        }
    }
}
