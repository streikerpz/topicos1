using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Topicos.NorthWnd.Model.Models
{
    public partial class Order
    {
        [NotMapped]
        public string OrderDuration
        {
            get
            {
                var resultado = "Order not Shipped";
                if (this.ShippedDate != null && this.OrderDate != null) 
                {
                    var hoursTaken = (this.ShippedDate.Value - this.OrderDate.Value).TotalHours;
                    resultado = "The order took " + hoursTaken +" hours to be shipped";
                }
                return resultado;
            }
            set 
            { }
        }
    }
}
