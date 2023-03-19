﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingWeb.Areas.admin.Controllers
{
    [Area("Admin")]  
    
    public class SearchController : Controller
    {
        private readonly dbMarketsContext _context;
        public SearchController(dbMarketsContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if(string.IsNullOrEmpty(keyword )|| keyword.Length <1) {
                return PartialView("ListProductsSearchPartialView", null);
                    }

            ls = _context.Products.AsNoTracking().
                Include(a => a.Cat).
                Where(x => x.ProductName.Contains(keyword)).
                OrderByDescending(x => x.ProductName).
                Take(10).
                ToList();
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartialView", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartialView", ls);
            }
        }
        
    }
}
