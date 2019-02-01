using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public interface IUserCurrenciesRepository
    {
        IQueryable<UserCurrencies> GetCurrenciesByUserId(string userId);
        UserCurrencies GetCurrencyByCurrencyCode(string currencyCode);
    }
}
