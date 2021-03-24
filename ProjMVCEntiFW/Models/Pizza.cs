using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjMVCEntiFW.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}