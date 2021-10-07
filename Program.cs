using System;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name,string[] Dishes) User;

            Console.WriteLine("Введите имя пользователя:");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for(int i = User.Dishes.Length - 1;i >= 0;i--)
            {
                Console.WriteLine("Введите любимое блюдо №{0}",i+1);
                User.Dishes[i] = Console.ReadLine();
            }

        }
    }
}
