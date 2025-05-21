using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _6._5._25.Models;

namespace _6._5._25.Pages
{
    public class SaveProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new Product();

        public IActionResult OnGet()
        {
            // Get the product data from TempData
            if (TempData["ProductId"] != null && TempData["ProductName"] != null)
            {
                Product = new Product
                {
                    Id = Convert.ToInt32(TempData["ProductId"]),
                    Name = TempData["ProductName"].ToString()
                };
                return Page();
            }

            // If no product data is found, redirect back to the form
            return RedirectToPage("/HelloWorld");
        }
    }
} 