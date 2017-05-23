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
    public class TrunkTracerTests
    {
        [TestMethod()]
        public void TraceBoardConenctionsTest()
        {
            TrunkTracer tracer = new TrunkTracer();
            Board board = new Board(12, 12, 0);
            var result = tracer.TraceBoardConenctions(board);

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0.0, result.TimeOfWork, 0.9);
        }
    }
}