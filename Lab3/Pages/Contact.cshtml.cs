using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor1.Pages
{
    public class ContactModel : PageModel
    {
        private readonly Data.JsonDataProvider<Data.Contact> _context;
        
        public ContactModel(Data.JsonDataProvider<Data.Contact> context)
        {
            _context = context;
        }

        [BindProperty]
        public Data.Contact Contact { get; set; }

        public IActionResult OnPostSend()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //_context.AddData(Contact);

            return RedirectToPage("Thanks"); 
        }
    }
}
