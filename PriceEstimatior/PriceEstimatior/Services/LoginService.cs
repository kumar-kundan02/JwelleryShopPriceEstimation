using PriceEstimatior.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PriceEstimatior.Services
{
    internal class LoginService
    {
        static List<Customer> customers = new List<Customer>();

        static LoginService()
        {
            customers.Add(new Customer { Name = "c1", Password = "c1", Category = CustomerType.Regular });
            customers.Add(new Customer { Name = "c2", Password = "c2", Category = CustomerType.Privilege });
        }
       
        internal Customer Authenticate(string userName, string password)
        {
            return customers.Where(c => c.Name == userName && c.Password == password).FirstOrDefault();
        }
    }
}