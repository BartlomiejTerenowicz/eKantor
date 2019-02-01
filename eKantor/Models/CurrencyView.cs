using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public class CurrencyView
    {
        public string CurrencyName { get; set; }
        public uint Unit { get; set; }
        public decimal Price { get; set; }
    }
}
