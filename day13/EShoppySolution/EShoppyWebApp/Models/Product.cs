using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EShoppyWebApp.Models
{
    public class Product
    {
        [Required]
        public string ProductId { get; set; }

        [Required]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name ="Product Description")]
        public string ProductDescription { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        public Nullable<bool> ExistsInStock { get; set; }
    }
}