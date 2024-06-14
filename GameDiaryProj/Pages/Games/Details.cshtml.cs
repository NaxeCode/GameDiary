using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameDiaryProj.Data;
using GameDiaryProj.Models;

namespace GameDiaryProj.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly GameDiaryProj.Data.GameDiaryContext _context;

        public DetailsModel(GameDiaryProj.Data.GameDiaryContext context)
        {
            _context = context;
        }

        public Game Game { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);
            if (game == null)
            {
                return NotFound();
            }
            else
            {
                Game = game;
            }
            return Page();
        }
    }
}
