using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededler siyahisina verilmis ededi elave edib arrayi qaytaran metod
            int[] array = { 10, 33, 56 };
            Add(array, 12);

        }

        static int[] Add(int[] arr, int num)
        {
            int[] newArr =new int[arr.Length + 1];

            for(int i=0;i<arr.Length;i++)
            {
                newArr[i] = arr[i];

            }
            newArr[newArr.Length-1]=num;

            return newArr;
        }
        
        
    }
}
