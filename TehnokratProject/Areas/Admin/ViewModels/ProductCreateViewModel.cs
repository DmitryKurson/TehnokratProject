﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using TehnokratProject.Models;

namespace TehnokratProject.Areas.Admin.ViewModels
{
    public class ProductCreateViewModel
    {
       
        
        public string title { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string state { get; set; }
        public bool status { get; set; }
        public string image_path { get; set; }


        public int? category_id { get; set; }

        // Завантажене зображення
        [Display(Name = "Зображення")]
        public IFormFile ImageFile { get; set; }

        public List<string> StateOptions { get; set; } // Список для select
        public List<string> BrandOptions { get; set; } // Список для select
        [BindNever]
        public IEnumerable<Category> Categories { get; set; }
        
        public ProductCreateViewModel()
        {
            Categories = Enumerable.Empty<Category>();
        }
    }
}
