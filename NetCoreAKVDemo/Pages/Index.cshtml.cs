using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreAKVDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public string CurrentEnvironment { get; set; }
        public string OtherSecret { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            
        }

        public void OnGet()
        {
            this.CurrentEnvironment = _configuration["env"];
            this.OtherSecret= _configuration["otherSecret"];
        }
    }
}