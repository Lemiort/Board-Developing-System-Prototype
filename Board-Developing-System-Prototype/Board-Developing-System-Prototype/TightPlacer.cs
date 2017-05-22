using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// размещает элементы используя алгоритм плотного размещения
    /// </summary>
    class TightPlacer : IElementPlacer
    {
        public ElementPlacerResults PlaceElements(Board board)
        {



            // надеюсь этого не останется в конечной версии проекта
            return new ElementPlacerResults(((int)(((new Random()).NextDouble()) * 3) + 4) * board.ElemCount * board.ElemCount);
        }
    }
}
