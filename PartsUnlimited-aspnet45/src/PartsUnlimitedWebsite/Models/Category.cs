﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//this is my first code for CGI demo
namespace PartsUnlimited.Models
{
    public class Category
    {
            //Logging categories111222333
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}