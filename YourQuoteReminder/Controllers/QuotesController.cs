using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourQuoteReminder.Models;
using YourQuoteReminder.ViewModels ;

namespace YourQuoteReminder.Controllers
{
    public class QuotesController : Controller
    {
        // GET: Quotes
        public ActionResult Index()
        {
            var quotes = new List<Quote>() {
                new Quote {Id = 2, UserQuote = "Stay Positive", CreatedDateTime = DateTime.Now },
                new Quote {Id = 3, UserQuote = "Fight Mehdi Fight", CreatedDateTime = DateTime.Now },
                new Quote {Id = 1, UserQuote = "Never Give Up", CreatedDateTime = DateTime.Now },
                new Quote {Id = 4, UserQuote = "Never Forget the ways you have passed", CreatedDateTime = DateTime.Now }, 
                };
            var customer = new Customer() { Id = 1, Name = "Mehdi" };
            var qViewModel = new QuoteViewModel()
            {
                Customer = customer,
                Quotes = quotes
            };
            return View(qViewModel);
        }

        public ActionResult Add()
        {
            return Content("Hello");
        }

        public ActionResult Edit()
        {
            return Content("this is Edit ");
        }
    }
}