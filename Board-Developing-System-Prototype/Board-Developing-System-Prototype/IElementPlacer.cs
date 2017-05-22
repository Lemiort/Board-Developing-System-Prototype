using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// интерфейс работы ИМ алгоритма размещения элементов
    /// </summary>
    interface IElementPlacer
    {
        /// <summary>
        /// размещение элементов
        /// </summary>
        /// <param name="board">Исходная плата</param>
        /// <returns></returns>
        ElementPlacerResults PlaceElements(Board board);
    }
}
