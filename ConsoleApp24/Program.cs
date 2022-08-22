using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = 3;
            int numberOfColumns = 3;
            int sumOfSecondLine = 0;
            int productOfFirstColumn = 1;
            int[,] array = new int[numberOfLines, numberOfColumns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Random random = new Random();
                    int numberStartArray = 1;
                    int numberEndArray = 9;
                    array[i, j] = random.Next(numberStartArray, numberEndArray);
                    Console.Write(array[i, j] + " ");
                    if (i == 1)
                    {
                        sumOfSecondLine = sumOfSecondLine + array[i, j];
                    }
                    if (j == 0)
                    {
                        productOfFirstColumn = productOfFirstColumn * array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nCумма второй строки: {sumOfSecondLine} \nПроизведение первого столбца: {productOfFirstColumn}");
        }
    }
}
