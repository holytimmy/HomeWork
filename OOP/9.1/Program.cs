using System;

namespace _9._1
{
    public delegate int MyDelegate(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – 
вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два 
аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку 
деления на ноль. 
Написать программу, которая будет выполнять арифметические действия, указанные пользователем. */

            Console.WriteLine("Enter param1:");
            int param1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter param2:");
            int param2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation (+,-,*,/):");
            string operation = Convert.ToString(Console.ReadLine());
            int add = 0, sub = 0, mul = 0, div = 0;
            switch (operation)
            {
                case "+":
                    //MyDelegate Add = delegate (int a, int b) { return a + b; };
                    // можно упростить. записать в виде:
                    MyDelegate Add = (a, b) => a + b;
                    add = Add(param1, param2);
                    Console.WriteLine("{0} + {1} = {2}", param1, param2, add);
                    break;
                case "-":
                    //MyDelegate Sub = delegate (int a, int b) { return a - b; };
                    MyDelegate Sub = (a, b) => a - b;
                    sub = Sub(param1,param2);
                    Console.WriteLine("{0} - {1} = {2}", param1, param2, sub);
                    break;
                case "*":
                    //MyDelegate Mul = delegate (int a, int b) { return a * b; };
                    MyDelegate Mul = (a, b) => a * b;
                    mul = Mul(param1, param2);
                    Console.WriteLine("{0} * {1} = {2}", param1, param2, mul);
                    break;
                case "/":
                    //MyDelegate Div = delegate (int a, int b) { return a / b; };
                    //div = Div (param1, param2) =>
                    //{
                    //    if (b != 0)
                    //    {
                    //        return a / b;
                    //        Console.WriteLine("{0} / {1} = {2}", param1, param2, div);
                    //    }
                    //    else { return Console.WriteLine("Div na 0")};
                    //};

                    MyDelegate Div = (a, b) => { 
                        if (b == 0)
                        {
                            //тут может быть несколько вариантов. Либо возвращать MaxValue
                            //Console.WriteLine("Error. Devision by zero!!!");
                            //return Int32.MaxValue;

                            //либо кидать ошибку (что правильнее!!)
                            throw new DivideByZeroException("Error. Devision by zero!!!");
                        }
                        return a / b;
                    };
                    div = Div(param1, param2);
                    Console.WriteLine("{0} / {1} = {2}", param1, param2, div);
                    break;
                default:
                    Console.WriteLine("not correct operation");
                    break;
            }

                    Console.ReadKey();
            }
        }
    }
