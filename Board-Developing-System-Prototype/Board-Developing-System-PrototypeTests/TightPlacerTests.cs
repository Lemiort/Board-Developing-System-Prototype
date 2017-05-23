using Microsoft.VisualStudio.TestTools.UnitTesting;
using Board_Developing_System_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype.Tests
{
    [TestClass()]
    public class TightPlacerTests
    {
        [TestMethod()]
        public void PlaceElementsTest()
        {
            Board board = new Board(100, 100, 100);
            TightPlacer placer = new TightPlacer();
            var result = placer.PlaceElements(board);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0.0, result.TimeOfWork, 0.9);
        }
    }
}