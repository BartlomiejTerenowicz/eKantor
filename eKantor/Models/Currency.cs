using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }

        public string Name { get; set; }

        public int Unit { get; set; }

        public UserCurrencies UserCurrencies { get; set; }
    }

    public class UserCurrencies
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public string CurrencyCode { get; set; }

        public int Units { get; set; }

        public AppUser User { get; set; }

        public Currency Currencies { get; set; }
    }
}
