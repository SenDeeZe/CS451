using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Data;

namespace Razor1.Pages
{
    public class PortfolioModel : PageModel
    {
        public readonly IJsonDataProvider<Testimonial> _testimonials;

        public PortfolioModel(IJsonDataProvider<Testimonial> testimonials)
        {
            _testimonials = testimonials;
        }
        public void OnGet()
        {
        }
    }
}
