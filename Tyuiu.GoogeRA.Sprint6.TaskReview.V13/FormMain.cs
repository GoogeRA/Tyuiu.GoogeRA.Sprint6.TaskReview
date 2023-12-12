using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GoogeRA.Sprint6.TaskReview.V13.Lib;

namespace Tyuiu.GoogeRA.Sprint6.TaskReview.V13
{
    public partial class FormMain : Form
    {
        int[,] arrayValues;
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        public int[,] GetMatrix()
        { 
            int N = Convert.ToInt32(textBoxStolp_GRA.Text);
            int M = Convert.ToInt32(textBoxStroki_GRA.Text);
            int n1 = Convert.ToInt32(textBoxN1_GRA.Text);
            int n2 = Convert.ToInt32(textBoxN2_GRA.Text);
            int[,] matrix = new int[N, M];

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (!((j + 1) % 4 == 0))
                    {
                        matrix[i, j] = random.Next(n1, n2); // Заполнение случайными числами первых трех столбцов
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j - 3] - matrix[i, j - 2] - matrix[i, j - 1]; // Заполнение с чередованием через три значения разностью трех предыдущих значений
                    }
                }
                
            }
            return matrix;
           
        }

        private void buttonStart_GRA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int K = Convert.ToInt32(textBoxK_GRA.Text);
            int L = Convert.ToInt32(textBoxL_GRA.Text);
            int C = Convert.ToInt32(textBoxC_GRA.Text);

            textBoxResult_GRA.Text = Convert.ToString(ds.GetMatrix(arrayValues, K, L, C));
        }

        private void buttonGen_GRA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            arrayValues = GetMatrix();

            dataGridViewRes_GRA.ColumnCount = arrayValues.GetLength(1);
            dataGridViewRes_GRA.RowCount = arrayValues.GetLength(0);

           for(int i = 0; i < arrayValues.GetLength(0); i++ )
            {

                for(int j = 0; j < arrayValues.GetLength(1); j++)
                {
                    dataGridViewRes_GRA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }

            }

            buttonStart_GRA.Enabled = true;


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxResult_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void dataGridViewRes_GRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxK_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxL_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStroki_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
