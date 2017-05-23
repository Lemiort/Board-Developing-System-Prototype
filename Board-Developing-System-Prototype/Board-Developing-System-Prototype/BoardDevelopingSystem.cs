using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Developing_System_Prototype
{
    /// <summary>
    /// ИМ разработки в целом
    /// </summary>
    public class BoardDevelopingSystem
    {
        Board board;
        IElementLinker linker;
        IElementPlacer placer;
        IBoardTracer tracer;

        public BoardDevelopingSystem()
        {
            board = new Board(100, 100, 100);
            //linker \
            placer = new MatrixPlacer();
            tracer = new TrunkTracer();
        }

        public int DevelopBoard()
        {
            int summaryTime = 0;

            var result = placer.PlaceElements(board);
            summaryTime += result.TimeOfWork;

            var traceResult = tracer.TraceBoardConenctions(board);
            summaryTime += traceResult.TimeOfWork;

            return summaryTime;
        }
    }
}
