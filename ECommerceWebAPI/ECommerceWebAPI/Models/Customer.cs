using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ECommerceWebAPI.Models.Data
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Phoneno")]
        public string Phoneno { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "View Cart")]
        public string ViewCart { get; set; }
    }
}
