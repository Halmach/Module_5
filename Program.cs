using System;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //(string myName, byte age, DayOfWeek day, string birthdate) anketa;

            //Console.WriteLine("What is your name?");
            //anketa.myName = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //bool isAgeCorrenct = byte.TryParse(Console.ReadLine(), out anketa.age);
            //while (!isAgeCorrenct)
            //{
            //    Console.WriteLine("Enter your age");
            //    isAgeCorrenct = byte.TryParse(Console.ReadLine(), out anketa.age);
            //}
            //Console.WriteLine("What is your favourite day of week?");
            //anketa.day = (DayOfWeek)checked(byte.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter your birthdate: ");
            //anketa.birthdate = checked(Console.ReadLine());
            //Console.WriteLine("My name is {0}", anketa.myName);
            //Console.WriteLine("My age is {0}", anketa.age);
            //Console.WriteLine("Your favourite day of week is " + anketa.day);
            //Console.WriteLine("Your birthday is " + anketa.birthdate);

            


            //var favcolors = new string[3];

            //ShowArray(GetArrayFromConsole(10),true);
            ////var sortedarray = SortArray(GetArrayFromConsole(3));

            //for (int i = 0;i < favcolors.Length;i++)
            //{
            //    favcolors[i] = ChangeColor(anketa.myName,anketa.age);
            //}
            ////ShowColors(anketa.myName, favcolors[0],favcolors[2]);
            //ShowColors();

            string test_name = "Vasya";
            Console.WriteLine(test_name);
            GetName(test_name); //  работа по значению.
            Console.WriteLine(test_name);

            int age = 20;
            Console.WriteLine(age);
            ChangeAge(age); //  работа по значению.
            Console.WriteLine(age);

            ChangeName(ref test_name); // работа по ссылке
            Console.WriteLine(test_name); 

        }

        static string ChangeColor(string name, int userage)
        {
            Console.WriteLine(Environment.NewLine + name + " " + userage + " лет,"+ Environment.NewLine + "напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine().ToLower();
            switch(color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;     
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;        
                case "green":    
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;       
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

            }

            
            return color;
        }

        static void ShowColors(string username = "Ruslan", params string[] favcolors)
        {
            Console.WriteLine(username + " ,Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static int[] GetArrayFromConsole(int num = 3)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] array)
        {
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
            return array;
        }

        static void ShowArray(int[] array,bool switchSort = false)
        {
            int[] result;
            if (switchSort) result = SortArray(array);
            else result = array;
            foreach (var arrItem in result) Console.Write(arrItem + " ");
        }

        static void GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите возраст:");
            age = Convert.ToInt32(Console.ReadLine());
        }
        static void ChangeName(ref string name)
        {
            Console.WriteLine("Введите имя(работа по ссылке):");
            name = Console.ReadLine();
        }

    }
}
