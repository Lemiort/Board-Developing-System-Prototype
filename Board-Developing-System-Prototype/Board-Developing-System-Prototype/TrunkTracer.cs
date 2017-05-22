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
    class TrunkTracer : IBoardTracer
    {
        public BoardTracerResults TraceBoardConenctions(Board board)
        {


            // надеюсь этого не останется в конечной версии проекта
            return new BoardTracerResults(((int)(((new Random()).NextDouble()) * 3) + 14) * board.ElemCount * board.ElemCount * 20);
        }
    }
}
