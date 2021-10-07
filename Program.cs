using System;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            int i = 1, j = 2;
            while (i < array.Length)
            {
                if (array[i - 1] <= array[i]) { i = j; j++; }
                else
                {
                    int t = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = t;
                    i--;
                    if (i == 0) { i = j; j++; }
                }
            }
            foreach (var arrItem in array) Console.Write(arrItem + " ");

        }

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            return color;
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

    }
}
