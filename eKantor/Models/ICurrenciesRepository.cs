﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Models
{
    public interface ICurrenciesRepository
    {
        IQueryable<Currency> Currencies { get; }
    }
}
