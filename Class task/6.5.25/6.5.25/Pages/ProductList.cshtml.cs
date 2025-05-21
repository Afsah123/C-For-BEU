using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _6._5._25.Models;
using System.Collections.Generic;

namespace _6._5._25.Pages
{
    public class ProductListModel : PageModel
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            Products = ProductService.GetAllProducts();
        }

        public IActionResult OnPost(int id)
        {
            ProductService.DeleteProduct(id);
            return RedirectToPage();
        }
    }
} 