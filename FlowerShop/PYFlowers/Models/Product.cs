using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PYFlowers.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please provide a short description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please indicate the season")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter the flower name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Product Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please indicate how much in stock")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Please indicate if it can be wrapped")]
        public string Wrap { get; set; }
        [Required(ErrorMessage = "Please indicate if it can be gifted")]
        public string Gift{ get; set; }
    }
}
