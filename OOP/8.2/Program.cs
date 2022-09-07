using System;

namespace _8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
Присвойте каждой константе значение, задающее количество часов, которые должен отработать 
сотрудник за месяц. 
Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее 
давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему 
положена премия.*/

            Accauntant accauntant = new Accauntant();
            accauntant.AskForBonus(Post.director, 300);
            accauntant.AskForBonus(Post.financeDirector, 150);
            accauntant.AskForBonus(Post.driver, 50);
            accauntant.AskForBonus(Post.engineer, 200);
            accauntant.AskForBonus(Post.secretary, 200);
            accauntant.AskForBonus(Post.manager, 350);

            Console.ReadKey();
        }
    }
}
