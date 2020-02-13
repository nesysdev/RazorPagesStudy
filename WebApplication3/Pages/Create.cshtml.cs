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
    public class CreateModel : PageModel
    {
        private readonly IBoardRepository _boardRepository;

        public CreateModel(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        [BindProperty]
        public Board BoardModel { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var board = _boardRepository.AddBoard(BoardModel);
            if (board == null)
            {
                ModelState.AddModelError("", "������� ���߽��ϴ�.");
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}
