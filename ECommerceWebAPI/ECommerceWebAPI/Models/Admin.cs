using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ECommerceWebAPI.Models.Data
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Display(Name = "UserName")]
        public string username { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }

    }
}
