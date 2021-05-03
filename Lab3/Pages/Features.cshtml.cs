using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Data;

namespace Razor1.Pages
{
    public class FeaturesModel : PageModel
    {
        public readonly IJsonDataProvider<Testimonial> _testimonials;

        public FeaturesModel(IJsonDataProvider<Testimonial> testimonials)
        {
            _testimonials = testimonials;
        }
        public void OnGet()
        {
        }
    }
}
