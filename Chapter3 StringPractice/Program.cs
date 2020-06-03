using System;

namespace Chapter3_StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1; 
            string str = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            for (int i = 0; i < str.Length; i++) {
                arr1[i] = str.Split(" ");
                Console.WriteLine(arr1[i]);




            }








        }
    }
}
