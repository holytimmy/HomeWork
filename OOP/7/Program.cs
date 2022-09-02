using System;

namespace _7
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта 
назначения, номер поезда, время отправления. 
Написать программу, выполняющую следующие действия: 
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть
упорядочены по номерам поездов);
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
вывести соответствующее сообщение).*/

            Train[] transport = new Train[8];

            for (int i = 0; i < transport.Length; i++)
            {
                Console.WriteLine($"enter a station of train {i + 1}:");
                transport[i].Station = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"enter # of train {i + 1}:");
                transport[i].NumberTrain = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"enter departure time of train {i + 1}:");
                transport[i].NumberDeparture = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("enter name of train:");
            string number = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < transport.Length; i++)
            {
                if (number == transport[i].NumberTrain)
                {
                    Console.WriteLine($"Station {transport[i].Station}, number{transport[i].NumberTrain},time departure{transport[i].NumberDeparture}");
                }
                else
                {
                    Console.WriteLine("don'n number of train");
                }
            }

            Console.ReadKey();
        }
    }
}
