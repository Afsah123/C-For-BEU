using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _6._5._25.Models;

namespace _6._5._25.Pages
{
    public class HelloWorldModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new Product();

        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                // Editing existing product
                var existingProduct = ProductService.GetProductById(id.Value);
                if (existingProduct != null)
                {
                    Product = existingProduct;
                }
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Product.Id == 0)
            {
                // Adding new product
                ProductService.AddProduct(Product);
            }
            else
            {
                // Updating existing product
                ProductService.UpdateProduct(Product);
            }

            // Store the product data in TempData
            TempData["ProductId"] = Product.Id;
            TempData["ProductName"] = Product.Name;

            // Redirect to the SaveProduct page
            return RedirectToPage("/SaveProduct");
        }
    }
}
