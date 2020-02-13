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
    public class IndexModel : PageModel
    {
        public readonly IBoardRepository _boardRepository;

        public IEnumerable<Board> BoardList;
        
        public IndexModel(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }
        
        public void OnGet()
        {
            BoardList = _boardRepository.GetBoards();
        }

        public void OnPost()
        {

        }
    }
}
