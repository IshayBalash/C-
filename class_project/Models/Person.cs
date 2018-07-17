using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Person
    {
        [MaxLength(9),Validation]
        public string Id { get; set; }

        [Required]
        public string PersonName { get; set; }
    }
}