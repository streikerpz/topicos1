using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Topicos.NorthWnd.Model.Models
{
    public partial class EmployeeTerritory
    {
        [NotMapped]
        public String GetTerritoryDescription
        {
            get { return this.Territory.TerritoryDescription; }
            set { }
        }
        [NotMapped]
        public String GetTerritoryId
        {
            get { return this.Territory.TerritoryId; }
            set { }
        }
        [NotMapped]
        public int GetEmployeeTerritoryId
        {
            get { return this.EmployeeId; }
            set { }
        }
    }
}
