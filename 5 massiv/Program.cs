using System;

namespace _5_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputArray = new int[10];
            int tempMaxNumberInARow = 1;
            int maxNumberInRow = 0;
            int numberMaxRow = int.MinValue;

            for (int i = 0; i < userInputArray.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                userInputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < userInputArray.Length; i++)
            {
                Console.Write(userInputArray[i] + " ");
            }

            for(int i = 0; i < userInputArray.Length - 1; i++)
            {

                if (userInputArray[i] == userInputArray[i + 1])
                {
                    tempMaxNumberInARow++;

                    if (tempMaxNumberInARow > maxNumberInRow)
                    {
                        maxNumberInRow = tempMaxNumberInARow;
                        numberMaxRow = userInputArray[i];
                    }
                }
                else
                {
                    tempMaxNumberInARow = 0;
                }
            }
            Console.WriteLine($"Больше всего поаторяется подряд число: {numberMaxRow}. Оно повторяеться {maxNumberInRow}");
        }
    }
}
