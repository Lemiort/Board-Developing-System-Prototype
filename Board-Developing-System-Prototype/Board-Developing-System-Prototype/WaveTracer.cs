using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// волоновой алгоритм трассировки
    /// </summary>
    public class WaveTracer : IBoardTracer
    {
        public BoardTracerResults TraceBoardConenctions(Board board)
        {

            // надеюсь этого не останется в конечной версии проекта
            return new BoardTracerResults(((int)(((new Random()).NextDouble()) * 6) + 10) * board.ElemCount * board.ElemCount * 20);
        }
    }
}
