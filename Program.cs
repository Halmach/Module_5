using System;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {

            (string myName, byte age, DayOfWeek day, string birthdate) anketa;

            Console.WriteLine("What is your name?");
            anketa.myName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            bool isAgeCorrenct = byte.TryParse(Console.ReadLine(), out anketa.age);
            while (!isAgeCorrenct)
            {
                Console.WriteLine("Enter your age");
                isAgeCorrenct = byte.TryParse(Console.ReadLine(), out anketa.age);
            }
            Console.WriteLine("What is your favourite day of week?");
            anketa.day = (DayOfWeek)checked(byte.Parse(Console.ReadLine()));
            Console.WriteLine("Enter your birthdate: ");
            anketa.birthdate = checked(Console.ReadLine());
            Console.WriteLine("My name is {0}", anketa.myName);
            Console.WriteLine("My age is {0}", anketa.age);
            Console.WriteLine("Your favourite day of week is " + anketa.day);
            Console.WriteLine("Your birthday is " + anketa.birthdate);




            var array = GetArrayFromConsole();
            int i = 1, j = 2;
            while (i < array.Length)
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
