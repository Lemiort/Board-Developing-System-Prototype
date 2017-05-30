using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// магистральный алгоритм трассировки
    /// </summary>
    public class TrunkTracer : IBoardTracer
    {
        public BoardTracerResults TraceBoardConenctions(Board board)
        {


            // надеюсь этого не останется в конечной версии проекта
            return new BoardTracerResults(((int)(((new Random()).Next(1, 100)) * 3) + 14) * board.ElemCount * board.ElemCount * 5 - (new Random()).Next(board.ElemCount * board.ElemCount));
        }
    }
}
