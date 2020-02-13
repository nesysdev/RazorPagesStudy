using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Service
{
    public interface IBoardRepository
    {
        IEnumerable<Board> GetBoards();

        Board GetBoard(int boardNo);

        Board AddBoard(Board newBoard);

        Board UpdateBoard(Board updatedBoard);

        Board DeletedBoard(int boardNo);
    }
}
