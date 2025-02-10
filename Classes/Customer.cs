using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace POS_Program.Classes
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Customer()
        {

        }

        public Customer(string name, string phone, string address, string city, string state, string zip)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }
    }
}
