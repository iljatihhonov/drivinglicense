using System;
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайка проверим, достаточно ли Вы взрослый для получения водительских прав. В каком годы Вы родились?");
            string yearOfBirth = Console.ReadLine();
            int yearOfBirthInt = Convert.ToInt32(yearOfBirth);
            int age = 2022 - yearOfBirthInt;
            if (age < 18)
            {
                Console.WriteLine("Рановато Вам ещё за руль садиться. Потерпите немного!");
            }
            if (age > 18)
            {
                Console.WriteLine("Да Вам уже давно можно за руль! Катайтесь осторожно!");
            }
            if (age == 18)
            {
                Console.WriteLine("Поздравляю, Вам как раз столько, сколько необходимо лет!");
            }
        }
    }
}