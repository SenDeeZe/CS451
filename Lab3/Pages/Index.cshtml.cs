using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Razor1.Data;

namespace Razor1.Pages
{

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly IJsonDataProvider<Testimonial> _testimonials;

        public IndexModel(ILogger<IndexModel> logger, IJsonDataProvider<Testimonial> testimonials)
        {
            _logger = logger;
            _testimonials = testimonials;
        }

        public IActionResult OnGet()
        {
            //_logger.LogInformation("Hello, World!");
            return Page();
        }
    }
}
