using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// хранит результаты работы ИМ размещения
    /// </summary>
    class ElementPlacerResults
    {
        /// <summary>
        /// время работы алгоритма
        /// </summary>
        private int timeOfWork;

        /// <summary>
        /// время работы алгоритма
        /// </summary>
        public int TimeOfWork
        {
            get
            {
                return timeOfWork;
            }
        }

        public ElementPlacerResults(int timeOfWork)
        {
            this.timeOfWork = timeOfWork;
        }
    }
}
