using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YourQuoteReminder.Models;

namespace YourQuoteReminder.ViewModels
{
    public class QuoteViewModel
    {
        public Customer Customer { get; set; }
        public List<Quote> Quotes { get; set; }

         
    }
}