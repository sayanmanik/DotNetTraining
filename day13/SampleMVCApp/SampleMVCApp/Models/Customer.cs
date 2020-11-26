using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleMVCApp.Models
{
    public class Customer
    {
        public int  Id { get; set; }

        [Required]
        //[DataType(DataType.Text)]
        [RegularExpression("^[A-Z][a-z]*")]
        [StringLength(30,MinimumLength =5)]
        //[MinLength=10]
        [Display(Name ="Customer Name")]
        //[Range(typeof(Int32),minimum:"1",maximum:"100")]
        [Range(1,100)]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[A-Z][a-z]*")]
        //[DataType(DataType.Text)]
        public string City { get; set; }
    }
}