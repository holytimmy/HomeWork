using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
        class Notes
        {
            private string text;
            public string Text { get { return text; } }

            public void SaveText(string text)
            {
                this.text = text;
                Console.WriteLine(text);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который 
позволит сохранять заметки читателя. */

            Book.Notes notes = new Book.Notes.();
            notes.SaveText("monday");

            Console.ReadKey();
        }
    }
}
