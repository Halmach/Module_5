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


            /* Основная разница в этом: когда параметры передаются по ссылке, 
             * они изменяются, когда по значению — нет. */
            //string test_name = "Vasya";
            //Console.WriteLine(test_name);
            //GetName(test_name); //  работа по значению.
            //Console.WriteLine(test_name);

            //int age = 20;
            //Console.WriteLine(age);
            //ChangeAge(age); //  работа по значению.
            //Console.WriteLine(age);

            //ChangeName(ref test_name); // работа по ссылке
            //Console.WriteLine(test_name); 

            //ChangeName_in(in test_name); // работа по ссылке без возможности измения
            //Console.WriteLine(test_name);


            //            var arr = new int[] { 1, 2, 3 };
            //int data = 100;
            //BigDataOperation(arr,ref data);

            //Console.WriteLine(arr[0]);
            //BigDataOperation(arr, ref data);
            //Console.WriteLine(arr[0]);
            //            int num = 10;
            //            arr = GetArrayFromConsole(ref num);
            //            ShowArray(arr);


            // Этот модификатор значит,
            // что параметр является выходным,
            // то есть его значение является результатом работы метода
            //GetName_modf_out(out test_name);
            //Console.WriteLine(test_name);

            //string oldname;
            //Console.WriteLine("oldname(before function) = " + oldname);

            // можно изменять несколько объектов в методе и возвращать их

            // out должно быть обязательно изменено, а ref можно не менять

            //Это является более удобной и краткой версией записи,
            //и далее эти переменные уже можно использовать.
            //GetName_modf_out_2(out string test_name, out string  oldname);
            //Console.WriteLine("oldname(after function) = " + oldname);
            //Console.WriteLine("test_name(after function) = " + test_name);

            //int[] array = new int[5] {1,422,-135,-53,341};
            //int[] array_1;
            //int[] array_2;
            //SortArray(in array, out array_1, out array_2);
            //Console.WriteLine("Исходный массив:");
            //ShowArray(array);
            //Console.WriteLine(Environment.NewLine + "Отсортированный массив(asc - от меньшего к большему)");
            //ShowArray(array_2);
            //Console.WriteLine(Environment.NewLine + "Отсортированный массив(desc - от большего к меньшему)");
            //ShowArray(array_1);



            //    Console.WriteLine("Напишите что-то");
            //    var str = Console.ReadLine();

            //    Console.WriteLine("Укажите глубину эха");
            //    var deep = int.Parse(Console.ReadLine());

            //    Echo(str, deep);

            //    Console.ReadKey();

            //Console.WriteLine(Factorial(20));


            Console.WriteLine(PowerUp(2,9));

        }

        public static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                //if (pow == 1)
                //{
                //    return N;
                //}
                //else
                //{
                    return N * PowerUp(N, --pow);
                //}
            }
        }
        //private static int PowerUp(int N, byte pow)
        //{
        //    if (pow > 0) {  return N * PowerUp(N,--pow); }
        //    else return 1;
        //}

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }


        static void Echo(string saidworld, int deep)
            {
                Console.BackgroundColor = (ConsoleColor)deep;
                Console.ForegroundColor = ConsoleColor.Black;
                saidworld = saidworld.Remove(0, 2);
                Console.WriteLine(saidworld);

                if (deep > 2)
                {
                    Echo(saidworld, deep - 1);
                }
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

    static int[] GetArrayFromConsole(ref int num)
    {
            num = 6;
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
           Console.WriteLine("Введите элемент массива номер {0}", i + 1);
           result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
{
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);
}

        static void ShowArray(int[] array, bool switchSort = false)
        {
            //int[] result;
            ////if (switchSort) result = SortArray(array);
            ////else 
            //    result = array;
            foreach (var arrItem in array) Console.Write(arrItem + " ");
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

static void ChangeName_in(in string name)
{
    Console.WriteLine("Передача имени по ссылке(без возможности изменения): " + name);
}


    /* Этот модификатор защищает данные от изменения: 
    * в методе их изменить нельзя, но сам параметр при этом передается по ссылке */
static void BigDataOperation(in int[] arr,ref int data) 
{
    data = 13;
    arr[0] = data;
}

        static void GetName_modf_out(out string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        static void GetName_modf_out_2(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static int SumNumbers(ref int num1,in int num2, out int num3, int num4)
        {
            num1 = 10;
            num3 = num1 + num2;
            return (num1 + num2 + num3) * num4;

        }

        static int[] SortArrayAsc(int[] array)
        {
            
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            int i = 1, j = 2;
            while (i < result.Length)
            {
                if (result[i - 1] <= result[i]) { i = j; j++; }
                else
                {
                    int t = result[i];
                    result[i] = result[i - 1];
                    result[i - 1] = t;
                    i--;
                    if (i == 0) { i = j; j++; }
                }
            }
            return result;
        }

        static int[] SortArrayDesc(int[] array)
        {
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            int i = 1, j = 2;
            while (i < result.Length)
            {
                if (result[i - 1] >= result[i]) { i = j; j++; }
                else
                {
                    int t = result[i];
                    result[i] = result[i - 1];
                    result[i - 1] = t;
                    i--;
                    if (i == 0) { i = j; j++; }
                }
            }
            return result;
        }



    }
}
