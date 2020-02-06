﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Freelancing_Projects_Portal_Core_Webapp.BussinessLayer;
using Freelancing_Projects_Portal_Core_Webapp.Models;

namespace Freelancing_Projects_Portal_Core_Webapp.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly Freelancing_Projects_Portal_Core_Webapp.Models.Freelancing_Projects_Portal_Context _context;

        public IndexModel(Freelancing_Projects_Portal_Core_Webapp.Models.Freelancing_Projects_Portal_Context context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await (from client in _context.Client select client).ToListAsync();
        }
    }
}
