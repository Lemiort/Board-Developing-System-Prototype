using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Developing_System_Prototype
{
    public partial class Form1 : Form
    {
        private int placerMethod = 0;
        private int tracerMethod = 0;

        BoardDevelopingSystem boardDevSystem = new BoardDevelopingSystem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(boardDevSystem.DevelopBoard().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssessmentForm assForm = new AssessmentForm();
            assForm.ShowDialog();

            DirectEstimationMethod placerDEM = new DirectEstimationMethod(assForm.AssessmentPlacer, 2, assForm.ExpertCount(), 4);
            DirectEstimationMethod tracerDEM = new DirectEstimationMethod(assForm.AssessmentTracer, 3, assForm.ExpertCount(), 4);

            string str = "Эксперты выбрали:" + Environment.NewLine;
            this.placerMethod = placerDEM.CalculateBestMethod() + 1;
            this.tracerMethod = tracerDEM.CalculateBestMethod() + 1;

            str += "Метод Рамещения:" + (placerMethod).ToString() + Environment.NewLine;
            str += "Метод трассировки" + (tracerMethod).ToString() + Environment.NewLine;

            mainConsole.AppendText(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IElementPlacer placer;
            IBoardTracer tracer;

            switch (placerMethod)
            {
                case 1: placer = new MatrixPlacer();
                    break;
                case 2: placer = new TightPlacer();
                    break;
                default: placer = new MatrixPlacer();
                    break;
            }

            switch (tracerMethod)
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

            Board board = new Board(100, 100, 100);


            ElementPlacerResults placerResult = placer.PlaceElements(board);
            BoardTracerResults tracerResult = tracer.TraceBoardConenctions(board);

            string str = "Время, затраченное на размещение: " + placerResult.TimeOfWork.ToString() + Environment.NewLine;
            str += "Время, затраченное на трассировку: " + tracerResult.TimeOfWork.ToString() + Environment.NewLine;
            mainConsole.AppendText(str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ты уверен?", "Ты меня нажал", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Мы тут уверенных не любим", "Уверенность Detected",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
