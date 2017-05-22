using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// интерфейс работы ИМ алгоритма трассировки платы
    /// </summary>
    interface IBoardTracer
    {
        /// <summary>
        /// трассировка платы
        /// </summary>
        /// <param name="board">исходная плата</param>
        /// <returns></returns>
        BoardTracerResults TraceBoardConenctions(Board board);
    }
}
