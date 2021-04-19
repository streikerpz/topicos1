using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Repositorio
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

        public IList<Model.Models.Employee> QryPorNombreJefaturaAproximado(string elNombreDeJefatura)
        {
            var laConsulta = _elContexto.Employees.Include(p => p.ReportsToNavigation).Where(p => p.ReportsToNavigation.FirstName.Contains(elNombreDeJefatura) || p.ReportsToNavigation.LastName.Contains(elNombreDeJefatura));
            laConsulta = laConsulta.OrderByDescending(p => p.FirstName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
        public IList<Model.Models.Employee> QryPorRangoDeEdad(decimal limiteInferior, decimal limiteSuperior)
        {
            // IQueryable
            var laConsulta = _elContexto.Employees.Where(p => (decimal)(DateTime.Now.Year - p.BirthDate.Value.Year) >= limiteInferior && (decimal)(DateTime.Now.Year - p.BirthDate.Value.Year) <= limiteSuperior);
            laConsulta = laConsulta.OrderBy(p => p.FirstName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Model.Models.Employee> QryPorRangoDeAntiguedad(decimal limiteInferior, decimal limiteSuperior)
        {
            // IQueryable
            var laConsulta = _elContexto.Employees.Where(p => (DateTime.Now.Year - p.HireDate.Value.Year) >= limiteInferior && (DateTime.Now.Year - p.HireDate.Value.Year) <= limiteSuperior);
            laConsulta = laConsulta.OrderBy(p => p.FirstName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
        public IList<Model.Models.Employee> QryPorDescripcionTerritorial(string descripcionTerritorial)
        {
            var laConsulta = _elContexto.Employees.Include(x => x.EmployeeTerritories).Where(p => p.EmployeeTerritories.Any(y => y.Territory.TerritoryDescription.Contains(descripcionTerritorial)));
            laConsulta = laConsulta.OrderBy(p => p.FirstName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
        public IList<Model.Models.Employee> QryPorNombreEmpleado(string nombreEmpleado)
        {
            var laConsulta = _elContexto.Employees.Where(p => p.FirstName.Contains(nombreEmpleado) || p.LastName.Contains(nombreEmpleado));
            laConsulta = laConsulta.OrderByDescending(p => p.FirstName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
    }

}
