using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить 
количество дней до его следующего дня рождения. */

            //Console.WriteLine("Enter date your next birthday:");
            //var dateString = Convert.ToString(Console.ReadLine());// "5/1/2008 8:30:52 AM";
            //DateTime dateBirthday = DateTime.Parse(dateString,System.Globalization.CultureInfo.InvariantCulture);

            DateTime dateBirthday = new DateTime(2022, 11, 15, 8, 0, 15);
            DateTime dateNow = DateTime.Now;

            TimeSpan interval = dateBirthday - dateNow;
            Console.WriteLine("There are " + interval.Days + " days left until the birthday");

            Console.ReadKey();
        }
    }
}
