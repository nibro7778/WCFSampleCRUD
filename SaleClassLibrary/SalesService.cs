using System;
using System.Collections.Generic;
using System.Linq;

namespace SaleClassLibrary
{
    public class SalesService : ISalesService
    {
        public bool InsertCustomer(Customer obj)
        {
            CustomerList.Add(obj);
            return true;
        }

        public List<Customer> GetAllCustomer()
        {
            return CustomerList;
        }

        public bool DeleteCustomer(int cid)
        {
            var item = CustomerList.First(x => x.CustomerId == cid);
            CustomerList.Remove(item);
            return true;
        }

        public bool UpdateCustomer(Customer obj)
        {
            var list = CustomerList;
            CustomerList.Where(p => p.CustomerId == obj.CustomerId).Update(p => p.CustomerName = obj.CustomerName);
            return true;
        }

        public static List<Customer> CustomerList = new List<Customer>()
        {
            new Customer()
            {
                CustomerId = 1, CustomerName = "Niraj", Address = "Vadodara", EmailId = "mailme7778@gmail.com"
            },
            new Customer()
            {
                CustomerId = 2, CustomerName = "Trivedi", Address = "Pune", EmailId = "testniraj@hotmail.com"
            }
        }; 
    }
    public static class LinqUpdates
    {
        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}