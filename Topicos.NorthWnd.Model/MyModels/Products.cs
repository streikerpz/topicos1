using System;
using System.Collections.Generic;
using System.Text;

namespace Topicos.NorthWnd.Model.Models
{
    public partial class Product
    {
        public int UnitsUnderStock { 
            get {
                var elResultado = 0;
                if (this.UnitsInStock != null && this.ReorderLevel != null)
                {
                    var laDiferencia = (int)this.UnitsInStock - (int)this.ReorderLevel;
                    elResultado = Math.Min(laDiferencia, 0);
                }
                return elResultado;
            }
            set { } }
    }
}
