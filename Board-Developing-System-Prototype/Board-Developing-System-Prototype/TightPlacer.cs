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
        public static Random rand = new Random();

        public ElementPlacerResults PlaceElements(Board board)
        {
            // индексы элементов которые ещё не размещены
            List<int> elemIndexes = new List<int>();
            for(int i = 0; i < board.ElemCount; i++)
            {
                elemIndexes.Add(i);
            }

            int sideCount = 0, iter = 1, time = 0;

            // цикл алгоритма
            while(elemIndexes.Count > 0)
            {
                // выбор элемента

                // поиск элемента с макс смежномтью
                int maxAdjacency = 0;
                int maxAdjacencyElemIndex = 0;
                foreach (int elemIndex in elemIndexes)
                {
                    time++;
                    int adj = Adjacency(elemIndex, board);
                    if (adj > maxAdjacency)
                    {
                        maxAdjacency = adj;
                        maxAdjacencyElemIndex = elemIndex;
                    }
                }

                // выбор элемента и удаление его из списка
                // элементов которые ещё не размещены

                int currentElemIndex = maxAdjacencyElemIndex;
                elemIndexes.Remove(currentElemIndex);


                // сам алгоритм
                if(iter == 1)
                {
                    time++;
                    sideCount += 4;
                }

                else
                {
                    time += 2*sideCount;
                    if (rand.NextDouble() > 0.5)
                        sideCount += 2;
                    if ((rand.NextDouble() > 0.5) && (sideCount > 4))
                        sideCount -= 2;
                    time++;
                }

                iter++;
            }



            // надеюсь этого не останется в конечной версии проекта
            //return new ElementPlacerResults(((int)(((new Random()).NextDouble()) * 3) + 4) * board.ElemCount * board.ElemCount);
            return new ElementPlacerResults(time);
        }

        /// <summary>
        /// поиск смежности элемента
        /// </summary>
        /// <param name="elemIndex">номер элемента</param>
        /// <param name="board">плата</param>
        /// <returns>Возвращает смежность элемента</returns>
        private int Adjacency(int elemIndex, Board board)
        {
            int result = 0;
            for(int i=0; i<board.ElemCount; i++)
            {
                result += board.WeightedMatrix1[i, elemIndex];
            }
            return result;
        }
    }
}
