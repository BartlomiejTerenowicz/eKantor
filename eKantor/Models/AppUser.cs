using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public class AppUser : IdentityUser
    {
        // Base ASP.NET Core Identity
        public List<UserCurrencies> UserCurrencies;
    }
}
