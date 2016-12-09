﻿using RestaurantJISH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantJISH.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int  ShoppingCartViewModelID {get; set; }
        public List<Cart> CartItems { get; set; }
        public double CartTotal { get; set; }
    }
}