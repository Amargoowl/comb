using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combination
{
    class Program
    {
        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {

            int[][] numbersIn = new int[4][];
            numbersIn[0] = new int[] { 1, 2 };
            numbersIn[1] = new int[] { 3, 4, 13, 14, 66 };
            numbersIn[2] = new int[] { 5, 6, 7, 8, 9 };
            numbersIn[3] = new int[] { 10, 11, 12};

            //находим общее число комбинаций
            int NumbersOfComb = 1;
            for (int l = 0; l < numbersIn.Length; l++)
            {
                NumbersOfComb *= numbersIn[l].Length;
            }
            //создаем выходной массив массивов
            int[][] numbersOut = new int[NumbersOfComb][];
            for(int l = 0; l < NumbersOfComb; l++)
            { 
                numbersOut[l] = new int[numbersIn.Length];
            }
            //заполняем выходной массив

            int h = 0;// элемент входного массива
            int j = 0;// элемнет выходного массива
            int i = 0;// индекс выходного массива
            int period = 1;// период текущего числа
            int k = 0; // количество периодов использования
            for (; i < numbersOut.Length && j < numbersOut[0].Length;)
            {
                if (i==0)
                {
                    h = 0;
                    for (int l = j+1; l < numbersIn.Length; l++)
                    {
                         period *= numbersIn[l].Length;                        
                    }
                    Console.WriteLine(period);
                }                
                if (k == period)
                {
                    h++;
                    if (h == numbersIn[j].Length)
                    {
                        h=0;
                    }
                    k = 0;
                }
                Console.WriteLine($"{i} {j} {j} {h}");
                numbersOut[i][j] = numbersIn[j][h];
                i++;
                k++;
                if (i == numbersOut.Length)
                {
                    i = 0;
                    j++;
                    period = 1;
                    k=0;
                }
            }
            for (int l = 0; l < numbersOut.Length; l++)
            {
                Console.Write($"{l + 1}\t");
                for (int m = 0; m < numbersOut[l].Length; m++)
                {
                    Console.Write(numbersOut[l][m] + "\t");
                }
                Console.Write("\n");
            }


            Console.ReadKey();
        }
    }
}
