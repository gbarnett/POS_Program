using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Program.Classes
{
    public class Order
    {
        public int ID {  get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public decimal Total { get; set; }

        List<Product> Products { get; set; }

        public Order()
        {

        }
    }
}
