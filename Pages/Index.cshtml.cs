using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SocialCards.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(Name = "title", SupportsGet = true)]
        public string Title { get; set; }
        
        [BindProperty(Name = "bg", SupportsGet = true)]
        public string BackgroundUrl { get; set; }
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}