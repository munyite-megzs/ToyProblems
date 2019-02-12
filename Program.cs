using System;
using System.Linq;

namespace Averybigsum
{
    class Program
    {
        static void Main(string[] args)
        {

            long results =0L;

            // get the array
            // get the array element
            //use the sum method of an array to sum up 

            long[] sumNo = { 1000000001,1000000002,1000000003,1000000004,1000000005 };

            results = sumNo.Sum();
            //for (long i = 0; i < sumNo.Length; i++)
            //{
            //    results += sumNo[i];
            //}
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
