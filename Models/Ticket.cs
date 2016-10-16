using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketMeisterIII.Models
{
    public class Ticket
    {
        public int ticketID { get; set; }

        [Display(Name = "Your Email")]
        public string customerID { get; set; }

        [Required]
        public string subject { get; set; }

        [Required]
        public string description { get; set; }

        public string response { get; set; }
        public string date { get; set; }
        public Boolean open { get; set; }

    }
}
