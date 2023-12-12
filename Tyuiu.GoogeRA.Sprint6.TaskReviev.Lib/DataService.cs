using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GoogeRA.Sprint6.TaskReviev.Lib
{
    public class DataService 
    {
        public int GetMatrix(int[,] matrix, int K, int L, int C)
        {

            int sum = 0;

            // Проверка на корректность ввода значений
            for (int i = K; i <= L; i += 2) // Цикл для суммирования только четных индексов
            {
                sum += matrix[i, C];


            }
            return sum;
        }
    }
}
