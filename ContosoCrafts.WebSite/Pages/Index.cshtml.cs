using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // public JsonFileProductService productService;
        // public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
        JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /* public JsonFileProductService ProductService "{ get; }" AUXENTE NO VÍDEO CORE 101 [5 OF 13] */
        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
