using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// размещает элементы в одногабаритные ячейки
    /// элементы должны иметь кратную величину для работы алгоритма
    /// </summary>
    class MatrixPlacer : IElementPlacer
    {



        public ElementPlacerResults PlaceElements(Board board)
        {


            // надеюсь этого не останется в конечной версии проекта
            return new ElementPlacerResults(((int)(((new Random()).NextDouble()) * 5) + 3) * board.ElemCount * board.ElemCount);
        }
    }
}
