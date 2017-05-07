using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
   
    interface IQualityChecker
    {
        /// <summary>
        /// проверка качества платы
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        BoardQuality CheckBoardQuality(Board board);
    }
}
