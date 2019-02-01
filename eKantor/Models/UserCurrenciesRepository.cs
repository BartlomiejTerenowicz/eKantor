using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public class UserCurrenciesRepository : IUserCurrenciesRepository
    {
        private AppIdentityDbContext context;

        public UserCurrenciesRepository(AppIdentityDbContext ctx)
        {
            this.context = ctx;
        }

        public IQueryable<UserCurrencies> GetCurrenciesByUserId(string userId)
        {
            var userCurrencies = context.UserCurrencies.Where(p => p.UserId == userId);
            return userCurrencies;
        }

        public UserCurrencies GetCurrencyByCurrencyCode(string currencyCode)
        {
            UserCurrencies result = context.UserCurrencies.Where(p => p.CurrencyCode == currencyCode).First();
            return result;
        }
    }
}
