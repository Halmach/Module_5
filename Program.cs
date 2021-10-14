using System;

namespace Module_5
{
    class Program
    {


        static (string name,string surName,int age,bool hasPet,int numPets,string[] petName,int numFavColors, string[] favColors) FillUserQuestionnaire()
        {
            (string name,string surName,int age,bool hasPet,int numPets,string[] petName, int numFavColors, string[] favColors) anketa = (null,null,0,false,0,null,0,null);

            consWrite("Введите имя:");
            anketa.name = consRead();
            Console.Clear();
            consWrite("Введите свою фамилию:");
            anketa.surName = consRead();
            Console.Clear();
            var isAgeCorrect = false;
            while (!isAgeCorrect)
            {
                consWrite("Введите возраст:");
                isAgeCorrect = checkEnterValue(consRead(), out anketa.age);
                Console.Clear();
            }
            var isHasPetCorrenct = false;
            anketa.hasPet = false;
            while (!isHasPetCorrenct)
            {
                consWrite("Есть ли у вас питомец?");

                switch(consRead().ToLower().Trim())
                {
                    case "да": case "yes": anketa.hasPet = true; isHasPetCorrenct = true; break;
                    case "нет": case "no": anketa.hasPet = false; isHasPetCorrenct = true; break;
                    default: Console.Clear(); continue;
                }
            }
            Console.Clear();
            if (anketa.hasPet)
            {
                var isnumPetsCorrect = false;
                do
                {
                    consWrite("Сколько у вас питомцев?");
                    isnumPetsCorrect = checkEnterValue(consRead(), out anketa.numPets);
                    Console.Clear();
                }
                while (!isnumPetsCorrect);
                anketa.petName = EnterPetsNames(anketa.numPets);
            }
            Console.Clear();
            bool isNumFavColorsCorrect = false;
            anketa.numFavColors = 0;
            for (;!isNumFavColorsCorrect;)
            {
                consWrite("Сколько у вас любимых цветов?");
                isNumFavColorsCorrect = checkEnterValue(consRead(), out anketa.numFavColors);
                Console.Clear();
            }
            EnterFavColors(anketa.numFavColors,out anketa.favColors);
            Console.Clear();




            consWrite("Имя: " + anketa.name);
            consWrite("Фамилия: " + anketa.surName);
            consWrite("Возраст: " + anketa.age);
            var petsExit = (anketa.hasPet) ? "да" : "нет";
            consWrite("Домашние питомцы: " + petsExit);
            if (anketa.hasPet)
            {
                if (anketa.numPets > 1)
                {
                    consWrite("Клички питомцев:");
                }
                else
                {
                    consWrite("Кличка питомца:");
                }

                foreach (string pet in anketa.petName)
                {
                    consWrite(pet);
                }
            }

            consWrite("Любимые цвета:");
            for(int i = 0; i < anketa.numFavColors; i++)
            {
                consWrite(anketa.favColors[i]);
            }
            
            return anketa;
        }

        static bool checkEnterValue(string value,out int result)
        {
           var isCorrect = int.TryParse(value, out result);
           if (result <= 0) isCorrect = false;
            return isCorrect;
        }

        static void consWrite(string value)
        {
            Console.WriteLine(value);
        }
        static string consRead()
        {
            return Console.ReadLine();
        }

        static void EnterFavColors(int num, out string[] colors)
        {
            colors = new string[num];
            for (int i = 0; i < colors.Length; i++)
            {
                consWrite("Введите любимый цвет №" + (i + 1));
                colors[i] = consRead();
                Console.Clear();
            }
        }
        static string[] EnterPetsNames(int num)
        {
            string[] petsNames = new string[num];
            for(int i = 0; i < petsNames.Length; i++)
            {
                consWrite("Введите кличку питомца №" + (i + 1));
                petsNames[i] = consRead();
                Console.Clear();
            }
            return petsNames;
        }

        static void Main(string[] args)
        {
            FillUserQuestionnaire();
            



        }

    }
}
