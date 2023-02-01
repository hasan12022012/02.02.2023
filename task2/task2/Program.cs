using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazıda rəqəm olub olmadığını tapan metod.Göndərilən yazıda rəqəm varsa true yoxdursa false qaytarır.
            Console.WriteLine("Hello everyone how are you");
            Console.Write("Insert word");
            string text = Console.ReadLine();
            Console.WriteLine(ContainsNumber(text));

        }
        static bool ContainsNumber(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
