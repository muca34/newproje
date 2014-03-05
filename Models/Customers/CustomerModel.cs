using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Komiks.Core.Domain.Customers;
using Komiks.Core.Domain.Orders;
using Komiks.Core.Domain.Taglar;

namespace Komiks.Web.Models.Customers
{
    public class CustomerModel
    {
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }
        public List<Tags> Tagses { get; set; }
    }
}