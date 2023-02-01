using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazıdaki sözlərin sayını tapan metod.Boşluqla bir birindən ayrılmış bütün ifadələri söz kimi qəbul edin.
            //Və hər söz arasında bir boşluq varmış kimi hesab edin.

            Console.WriteLine("Verilmiş yazıdaki sözlerin sayanı tapan metod.");
            Console.WriteLine("Text'i daxil edin");
            string text = Console.ReadLine();
            Console.WriteLine(count2(text));

            ;       }
        static int CountWords1(string text)
        {
            int count1 = 0;
            bool wordStarted = false;
            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c))
                {
                    wordStarted = false;
                }
                else if (!wordStarted)
                {
                    wordStarted = true;
                    count1++;
                }
            }
            return count1;
        }
        static int count2(string text)
        {
            string[] words = text.Split(' ');
            int count2 = words.Length;

            return count2;
        }
    }
}


    

