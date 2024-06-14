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
    public class IndexModel : PageModel
    {
        private readonly GameDiaryProj.Data.GameDiaryContext _context;

        public IndexModel(GameDiaryProj.Data.GameDiaryContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
