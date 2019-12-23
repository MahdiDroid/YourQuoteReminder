using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YourQuoteReminder.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string UserQuote { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}