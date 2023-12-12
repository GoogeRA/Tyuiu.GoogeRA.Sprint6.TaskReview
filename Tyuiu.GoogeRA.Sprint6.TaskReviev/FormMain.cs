using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GoogeRA.Sprint6.TaskReviev.Lib;

namespace Tyuiu.GoogeRA.Sprint6.TaskReviev
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_GRA.Filter = " Значение, разделенные запятыми(*.csv)|*.csv| Все файлы(*-*)|*-*";
            saveFileDialogMatrix_GRA.Filter = " Значение, разделенные запятыми(*.csv)|*.csv| Все файлы(*-*)|*-*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            //заменяет все значения в файле на рандомные
            int[,] arrayValues = new int[rows, columns];
            Random rnd = new Random();
            for (int r = 0; r < rows; r++)
            {
                string[] liner_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    
                    arrayValues[r, c] = Convert.ToInt32(liner_r[c]);
                    arrayValues[r, c] = rnd.Next(-30, 90);


                }
                  
            }
            return arrayValues;

            



        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Границы
            dataGridViewInPut_GRA.ColumnCount = 50;
            dataGridViewOutPut_GRA.ColumnCount = 50;

            dataGridViewInPut_GRA.RowCount = 50;
            dataGridViewOutPut_GRA.RowCount = 50;


            for (int i = 0; i < dataGridViewInPut_GRA.ColumnCount; i++)
            {
                dataGridViewInPut_GRA.Columns[i].Width = 25;
                dataGridViewOutPut_GRA.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_GRA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GRA.ShowDialog();
            openFilePath = openFileDialogTask_GRA.FileName;

            // выделить массив данных.

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_GRA.ColumnCount = columns;
            dataGridViewInPut_GRA.RowCount = rows;
            dataGridViewOutPut_GRA.ColumnCount = columns;
            dataGridViewOutPut_GRA.RowCount = rows;


            // задаем ширину столбца dataGridViewInPut_GRA.
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_GRA.Columns[i].Width = 25;
                dataGridViewOutPut_GRA.Columns[i].Width = 25;
            }

            // добавьте данные в dataGridViewInPut_GRA
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {

                    dataGridViewInPut_GRA.Rows[r].Cells[c].Value = arrayValues[r, c];

                }

            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonStart_GRA.Enabled = true;


        }


        private void buttonStart_GRA_Click(object sender, EventArgs e)
        {
            // применям библиотеку 
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_GRA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_GRA.Enabled = true;
        }

        private void buttonSave_GRA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GRA.FileName = "OutPutTask7V17.csv";
            saveFileDialogMatrix_GRA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GRA.ShowDialog();

            string path = saveFileDialogMatrix_GRA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_GRA.RowCount;
            int columns = dataGridViewOutPut_GRA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_GRA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_GRA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }



        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();

        }


    }
    
}


// Вывод массива на консоль для проверки
Console.WriteLine("Двумерный массив:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}