using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// трассировщик платы
    /// </summary>
    interface IBoardTracer
    {
        void TraceBoardConenctions(ref Board board);
    }
}
