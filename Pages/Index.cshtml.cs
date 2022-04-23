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
    public class IndexModel : PageModel
    {
        private readonly AssetDbContext _context; // Repaces "db" variable
        public List<User> Users {get; set;}
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(AssetDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Users = _context.Users.ToList();
        }
    }
}
