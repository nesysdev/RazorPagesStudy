using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Service
{
    public class MockBoardRepository : IBoardRepository
    {
        private List<Board> _boards = new List<Board>();

        public MockBoardRepository()
        {
            for (var i=0; i<5; i++)
            {
                _boards.Add(new Board()
                {
                    No = i,
                    Title = "제목" + i,
                    Content = "내용" + i
                });
            }
        }

        public Board AddBoard(Board newBoard)
        {
            newBoard.No = _boards.Max(e => e.No) + 1;
            _boards.Add(newBoard);
            return newBoard;
        }

        public Board DeletedBoard(int boardNo)
        {
            throw new NotImplementedException();
        }

        public Board GetBoard(int boardNo)
        {
            return _boards.FirstOrDefault(e => e.No == boardNo);
        }

        public IEnumerable<Board> GetBoards()
        {
            return _boards;
        }

        public Board UpdateBoard(Board updatedBoard)
        {
            var board = GetBoard(updatedBoard.No);
            if (board != null)
            {
                board.Title = updatedBoard.Title;
                board.Content = updatedBoard.Content;
            }
            return board;
        }
    }
}
