using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YourQuoteReminder.Models
{
    public class Quote
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string UserQuote { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}