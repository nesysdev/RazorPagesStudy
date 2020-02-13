using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;
using WebApplication3.Service;

namespace WebApplication3.Pages
{
    public class ViewModel : PageModel
    {
        private readonly IBoardRepository _boardRepository;

        public ViewModel(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public Board BoardModel { get; set; }

        [BindProperty(SupportsGet = true)]
        public int BoardNo { get; set; }

        public IActionResult OnGet()
        {
            if (BoardNo < 0)
            {
                return RedirectToPage("Index");
            }

            BoardModel = _boardRepository.GetBoard(BoardNo);

            return Page();
        }
    }
}
