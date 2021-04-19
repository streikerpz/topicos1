using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Topicos.NorthWnd.Model.Models
{
    public partial class Employee
    {
        [NotMapped]
        public String FullName
        {
            get
            {
                return (this.TitleOfCourtesy + " " + this.FirstName + " " + this.LastName);
            }
            set { }
        }
        [NotMapped]
        public String EmployeeReportsTo
        {
            get
            {
                var resultado = "Boss";
                if (this.ReportsTo.HasValue)
                {
                    resultado = this.ReportsToNavigation.FullName;
                }
                return resultado;
            }
            set { }
        }
        [NotMapped]
        public int AgeInYears
        {
            get
            {
                return (DateTime.Now.Year - this.BirthDate.Value.Year);
            }
            set { }
        }
        [NotMapped]
        public int Antiquity
        {
            get
            {
                return (DateTime.Now.Year - this.HireDate.Value.Year);
            }
            set { }
        }

    }
}
