using System;

namespace Chapter3_StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr1 = new string[32];
            string str = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            //char splitchar = ' ';
            string[] arr1 = str.Split(", ");

            for (int i = 0; i < arr1.Length; i++) {
                         
            }
            Console.WriteLine(string.Join(" ", arr1));
           






        }
    }
}
