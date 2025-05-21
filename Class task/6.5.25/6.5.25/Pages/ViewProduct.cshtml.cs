using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _6._5._25.Models;

namespace _6._5._25.Pages
{
    public class ViewProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new Product();

        public void OnGet()
        {
            // Initialize with default values or load from database
            Product = new Product
            {
                Id = 1,
                Name = "Sample Product"
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Here you would typically save the product to a database
            // For now, we'll just redirect back to the same page
            return RedirectToPage();
        }
    }
} 