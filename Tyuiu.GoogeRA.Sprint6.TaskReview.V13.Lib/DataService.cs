using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.GoogeRA.Sprint6.TaskReview.V13.Lib
{
    public class DataService 
    {
        public int GetMatrix(int[,] matrix, int K, int L, int C)
        {
              
            // Получение суммы значений из элементов с чётными номерами от K до L включительно в заданном столбце C
           
            int sum = 0;

            // Проверка на корректность ввода значений
            for(int i = K; i <= L; i += 2) // Цикл для суммирования только четных индексов
            {   
               sum += matrix[i, C];
                
            }
            return sum;
        }
    }
}
