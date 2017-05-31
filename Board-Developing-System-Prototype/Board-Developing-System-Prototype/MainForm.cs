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
    public partial class MainForm : Form
    {
        private int placerMethod = 0;
        private int tracerMethod = 0;

        BoardDevelopingSystem boardDevSystem = new BoardDevelopingSystem();

        public MainForm()
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

            str += "Метод Рамещения: " + (placerMethod).ToString() + Environment.NewLine;
            str += "Метод трассировки: " + (tracerMethod).ToString() + Environment.NewLine;

            label1.Text = "Выбранный Метод: " + (placerMethod).ToString() + Environment.NewLine;
            label2.Text = "Выбранный Метод: " + (tracerMethod).ToString() + Environment.NewLine;

            mainConsole.AppendText(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((placerMethod != 0) && (tracerMethod != 0))
            {
                BoardDevelopingSystem boardDS = new BoardDevelopingSystem(placerMethod, tracerMethod, new Board(100, 100, 100));
                var result = boardDS.DevelopBoard();
                label3.Text = "Затраченное время:\n" + result.PlaceTime;
                label4.Text = "Затраченное время:\n" + result.TraceTime;
                mainConsole.AppendText(result.ToString());
            }
            else
            {
                MessageBox.Show("Не проведён опрос экспертов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
