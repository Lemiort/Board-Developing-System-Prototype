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
        IElementPlacer placer;
        IBoardTracer tracer;


        public class DeveleopResult
        {
            public int TotalDevelopingTime
            {
                get
                {
                    return PlaceTime + TraceTime;
                }
            }
            public int PlaceTime { get; set; }
            public int TraceTime { get; set; }

            public override string ToString()
            {
                string str = "Время, затраченное на размещение: " + PlaceTime + Environment.NewLine;
                str += "Время, затраченное на трассировку: " + TraceTime + Environment.NewLine;
                str += "Суммарное время: " + TotalDevelopingTime + Environment.NewLine;

                return str;
            }
        }

        public BoardDevelopingSystem()
        {
            board = new Board(100, 100, 100);
            placer = new MatrixPlacer();
            tracer = new TrunkTracer();
        }

        public BoardDevelopingSystem(int placerID, int tracerID, Board board)
        {
            this.board = board;

            switch (placerID)
            {
                case 1:
                    placer = new MatrixPlacer();
                    break;
                case 2:
                    placer = new TightPlacer();
                    break;
                default:
                    placer = new MatrixPlacer();
                    break;
            }

            switch (tracerID)
            {
                case 1:
                    tracer = new WaveTracer();
                    break;
                case 2:
                    tracer = new BeamTracer();
                    break;
                case 3:
                    tracer = new TrunkTracer();
                    break;
                default:
                    tracer = new WaveTracer();
                    break;
            }
        }


        public DeveleopResult DevelopBoard()
        {
            int summaryTime = 0;

            var placerResult = placer.PlaceElements(board);
            summaryTime += placerResult.TimeOfWork;

            var tracerResult = tracer.TraceBoardConenctions(board);
            summaryTime += tracerResult.TimeOfWork;

            string str = "Время, затраченное на размещение: " + placerResult.TimeOfWork.ToString() + Environment.NewLine;
            str += "Время, затраченное на трассировку: " + tracerResult.TimeOfWork.ToString() + Environment.NewLine;
            str += "Суммарное время: " + summaryTime + Environment.NewLine;

            //return str;
            DeveleopResult res = new DeveleopResult();
            res.PlaceTime = placerResult.TimeOfWork;
            res.TraceTime = tracerResult.TimeOfWork;
            return res;
        }
    }
}
