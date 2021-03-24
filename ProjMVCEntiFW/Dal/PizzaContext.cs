using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjMVCEntiFW.Models;

namespace ProjMVCEntiFW.Dal
{
    public class PizzaContext : DbContext
    {
        public PizzaContext() : base("PizzaContext")//construtor
        {
        }

        public DbSet<Pizza> Pizzas { set; get; }

    }
}