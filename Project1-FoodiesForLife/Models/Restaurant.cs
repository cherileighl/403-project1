﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1_FoodiesForLife.Models
{
    public class Restaurant
    {
        [Required]
        public static int restID { get; set; }

        [Required(ErrorMessage = "Please enter a restaurant name.")]
        [MaxLength(50, ErrorMessage = "50 character limit.")]
        [Display(Name = "Restaurant Name")]
        public static string restName { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        [Display(Name = "Restaurant Category")]
        public static string restCategory { get; set; }
    }
}