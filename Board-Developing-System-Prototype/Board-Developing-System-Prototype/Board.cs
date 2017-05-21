using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// класс печатной платы, содержит исчерпывающую инфолрмаицю
    /// о плате, включая размещение, трассировку и пр.
    /// </summary>
    class Board
    {
        /// <summary>
        /// высота
        /// </summary>
        private double heigh;

        /// <summary>
        /// ширина
        /// </summary>
        private double width;

        /// <summary>
        /// Площадь
        /// </summary>
        public double Square
        {
            get
            {
                return width * heigh;
            }
        }

        /// <summary>
        /// Длина
        /// </summary>
        public double Heigh
        {
            get
            {
                return heigh;
            }

            private set
            {
                heigh = value;
            }
        }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get
            {
                return width;
            }

            private set
            {
                width = value;
            }
        }

        /// <summary>
        /// Количество элементов
        /// </summary>
        public int ElemCount
        {
            get
            {
                return elemCount;
            }
        }

        /// <summary>
        /// Элементы на борде
        /// </summary>
        private List<Elem> elems;

        /// <summary>
        /// Количество элементов
        /// </summary>
        private int elemCount;

        public Board(double width, double heigh, int elemCount)
        {
            this.elemCount = elemCount;

            this.elems = new List<Elem>();
            // TODO: инициализировать элементы

            this.width = width;
            this.heigh = heigh;
        }


    }
}
