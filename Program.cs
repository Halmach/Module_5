using System;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {

            var favcolors = new string[3];
            for(int i = 0;i < favcolors.Length;i++)
            {
                favcolors[i] = ShowColor();
            }
            Console.WriteLine("Ваши любимые цвета");
            foreach(var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            return color;
        }

    }
}
