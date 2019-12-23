using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using YourQuoteReminder.Models;

namespace YourQuoteReminder
{
    public class QuoteDbContext :DbContext 
    {
        public DbSet<Quote> Quotes { get; set; }
    }
}