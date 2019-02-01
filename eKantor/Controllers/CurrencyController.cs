using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKantor.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKantor.Controllers
{
    public class CurrencyController : Controller
    {
        private ICurrenciesRepository repository;

        public CurrencyController(ICurrenciesRepository injectRepository)
        {
            this.repository = injectRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View(repository.Currencies);
        }
    }
}