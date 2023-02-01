using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(char.IsDigit('4'));
            Console.WriteLine(char.IsLetter('5'));
            Console.WriteLine(char.IsLetterOrDigit('A'));

            var letter=char.ToUpper('a');
            Console.WriteLine(letter);

            letter = char.ToLower('A');
            Console.WriteLine(letter);

            Console.WriteLine(char.IsUpper('a'));
            Console.WriteLine(char.IsLower('a'));


            string text3 = "";
            string newtext3 = text3.Substring(6, 11);
            Console.Write(newtext3);
            Console.Read();





            string text1 = "     Hi everyone     ";
            string newtext1 = text1.Trim();
            Console.WriteLine(newtext1);




            string text2 = "    Hi everyone     ";
            int newtext2 = text2.Length;

            Console.WriteLine(newtext2);

           

            
        }
    }
}
