using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManager.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Required field")]
        public string Description { get; set; }
        
        public List<Product> Products { get; set; }
    }
}
