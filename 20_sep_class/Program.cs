using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_sep_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5] { 45, 78, 99, 34, 59 };
            //int[] nums = new int [5];

            //Console.WriteLine("Original array---");
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Array.Copy(numbers, nums, numbers.Length);
            //int index = Array.IndexOf(numbers, 99);
            //Console.WriteLine("--Sorted array---");

            //Array.Sort(numbers);

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //string[] names = new string[4] { "Akshay", "Shubham", "Rohit", "Prashant" };
            //Console.WriteLine("___original array----");
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("---Modified array----");
            ////Array.Clear(names,2, 2);
            //Array.Sort(names);

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            //{

            //}
            //Array.Reverse(names);

            ///// Two- diemnesiona array

            int[,] numbers_ = new int[3, 4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 }
            };

            foreach (int innerarray in numbers_)
            {
                //foreach (int item in innerarray)
                //{
                //    Console.Write(item);
                //}
                Console.WriteLine(innerarray);
            }
            {

            }
            
        }
    }
}
