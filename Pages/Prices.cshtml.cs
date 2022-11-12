using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SiteForAtelieRazorNetCore.Pages
{
    public class PricesModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "тут цены будут указаны, повторно.";
        }
    }
}
