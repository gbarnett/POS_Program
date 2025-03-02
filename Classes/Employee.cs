﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Program.Classes
{
    public class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip {  get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Username { get; set; }
        private string Password;

        public int isAdmin { get; set; }


        public string GetPassword()
        {
            return this.Password;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }

        public Employee()
        {

        }
    }
}
