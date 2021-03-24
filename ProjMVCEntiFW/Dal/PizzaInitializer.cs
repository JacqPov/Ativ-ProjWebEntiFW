using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjMVCEntiFW.Models;

namespace ProjMVCEntiFW.Dal
{
    public class PizzaInitializer : DropCreateDatabaseIfModelChanges<PizzaContext>
    {
        protected override void Seed(PizzaContext context)
        {
            var pizza = new List<Pizza>
            {
                new Pizza{Id = 1, Descricao = "Pizza Marguerita", Valor = 40},
                new Pizza{Id = 2, Descricao = "Pizza de Lombo", Valor = 50}
            };

            pizza.ForEach(p => context.Pizzas.Add(p));
            context.SaveChanges();
        }
    }
}