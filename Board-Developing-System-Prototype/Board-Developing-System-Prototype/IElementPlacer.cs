﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    interface IElementPlacer
    {
        void PlaceElements(ref Board board);
    }
}