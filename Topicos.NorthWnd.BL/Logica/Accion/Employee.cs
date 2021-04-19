using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Accion
{
    internal class Employee
    {
        private NorthWindContext _elContexto;

        public Employee()
        {

        }

        public Employee(NorthWindContext elContexto)
        {
            _elContexto = elContexto;
        }

        public IList<Model.Models.Employee> QryPorNombreJefatura(string elNombreDeJefatura)
        {
            var elRepositorio = new Logica.Repositorio.Employee(_elContexto);
            var elResultado = elRepositorio.QryPorNombreJefaturaAproximado(elNombreDeJefatura);
            return elResultado;
        }
        public IList<Model.Models.Employee> QryPorRangoDeEdad(decimal limiteInferior, decimal limiteSuperior)
        {
            var elRepositorio = new Logica.Repositorio.Employee(_elContexto);
            var elResultado = elRepositorio.QryPorRangoDeEdad(limiteInferior, limiteSuperior);
            return elResultado;
        }

        public IList<Model.Models.Employee> QryPorRangoDeAntiguedad(decimal limiteInferior, decimal limiteSuperior)
        {
            var elRepositorio = new Logica.Repositorio.Employee(_elContexto);
            var elResultado = elRepositorio.QryPorRangoDeAntiguedad(limiteInferior, limiteSuperior);
            return elResultado;
        }
        public IList<Model.Models.Employee> QryPorDescripcionTerritorial(string elNombreDeJefatura)
        {
            var elRepositorio = new Logica.Repositorio.Employee(_elContexto);
            var elResultado = elRepositorio.QryPorDescripcionTerritorial(elNombreDeJefatura);
            return elResultado;
        }
        
        public IList<Model.Models.Employee> QryPorNombreEmpleado(string nombreEmpleado)
        {
            var elRepositorio = new Logica.Repositorio.Employee(_elContexto);
            var elResultado = elRepositorio.QryPorNombreEmpleado(nombreEmpleado);
            return elResultado;
        }
    }
}
