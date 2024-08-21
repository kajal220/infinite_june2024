using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi_CC10.Models
{
    public class Country
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string CountryName { get; set; }
        public string Capital { get; set; }
    }
}