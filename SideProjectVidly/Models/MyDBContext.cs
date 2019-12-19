using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SideProjectVidly.Models;

namespace SideProjectVidly.Models
{
    public class MyDBContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}