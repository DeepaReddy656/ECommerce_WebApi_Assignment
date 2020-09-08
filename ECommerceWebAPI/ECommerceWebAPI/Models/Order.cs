using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ECommerceWebAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Display(Name = "Customer name")]
        public string OrderCustomerName { get; set; }

        [Display(Name = "Price")]
        public int OrderPrice { get; set; }

        [Display(Name = "Address")]
        public string OrderAddress { get; set; }

        [Display(Name = "Date")]
        public DateTime OrderDate { get; set; }

    }
}
