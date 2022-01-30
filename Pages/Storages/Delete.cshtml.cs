using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Deritei_Norbert_Proiect.Data.Deritei_Norbert_ProiectContext _context;

        public DeleteModel(Deritei_Norbert_Proiect.Data.Deritei_Norbert_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Storage Storage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Storage = await _context.Storage.FirstOrDefaultAsync(m => m.ID == id);

            if (Storage == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Storage = await _context.Storage.FindAsync(id);

            if (Storage != null)
            {
                _context.Storage.Remove(Storage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
