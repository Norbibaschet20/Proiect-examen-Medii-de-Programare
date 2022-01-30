﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Deritei_Norbert_Proiect.Data;
using Deritei_Norbert_Proiect.Models;

namespace Deritei_Norbert_Proiect.Pages.Storages
{
    public class IndexModel : PageModel
    {
        private readonly Deritei_Norbert_Proiect.Data.Deritei_Norbert_ProiectContext _context;

        public IndexModel(Deritei_Norbert_Proiect.Data.Deritei_Norbert_ProiectContext context)
        {
            _context = context;
        }

        public IList<Storage> Storage { get;set; }

        public async Task OnGetAsync()
        {
            Storage = await _context.Storage.ToListAsync();
        }
    }
}
