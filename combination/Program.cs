using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combination
{
    public class Program
    {
        public static int[][] Combination(params int[][] numbersIn)
        {
            //находим общее число комбинаций
            int numbersOfComb = 1;
            for (int l = 0; l < numbersIn.Length; l++)
            {
                numbersOfComb *= numbersIn[l].Length;
            }
            //создаем выходной массив массивов
            int[][] numbersOut = new int[numbersOfComb][];
            for (int l = 0; l < numbersOfComb; l++)
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
                if (i == 0)
                {
                    h = 0;
                    for (int l = j + 1; l < numbersIn.Length; l++)
                    {
                        period *= numbersIn[l].Length;
                    }                   
                }
                if (k == period)
                {
                    h++;
                    if (h == numbersIn[j].Length)
                    {
                        h = 0;
                    }
                    k = 0;
                }
 
                numbersOut[i][j] = numbersIn[j][h];
                i++;
                k++;
                if (i == numbersOut.Length)
                {
                    i = 0;
                    j++;
                    period = 1;
                    k = 0;
                }
            }

            return numbersOut;
        }

        static void Main(string[] args)
        {
            int[] numbersIn0 = new int[] { 1 , 2 };
            int[] numbersIn1 = new int[] { 2 , 4, 13, 14, 66 };
            int[] numbersIn2 = new int[] { 3 , 6, 7, 8, 9 };
            int[] numbersIn3 = new int[] { 10, 11, 12 };

            int[][] numbersOut = Combination(numbersIn0, numbersIn1, numbersIn2);// numbersIn3);

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
