using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить 
количество дней до его следующего дня рождения. */

            Console.WriteLine("Enter date your next birthday:");
            var dateString = Convert.ToString(Console.ReadLine());
            DateTime dateBirthday = DateTime.Parse(dateString);

            DateTime dateNow = DateTime.Now;

            TimeSpan interval = dateBirthday - dateNow;
            Console.WriteLine("There are " + interval.Days + " days left until the birthday");

            Console.ReadKey();
        }
    }
}
