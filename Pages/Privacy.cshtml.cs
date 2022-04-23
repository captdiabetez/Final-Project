using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AssetASP.Models;

namespace Final_Project.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly AssetDbContext _context; // Repaces "db" variable
        public List<Asset> Assets {get; set;}
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(AssetDbContext context, ILogger<PrivacyModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Assets = _context.Assets.ToList();
        }
    }
}
