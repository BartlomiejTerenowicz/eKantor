using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKantor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => 
            View(new Dictionary<string, object>
            { ["Miejsce zarezerwowane"] = "Miejsce zarezerwowane" });
    }
}
