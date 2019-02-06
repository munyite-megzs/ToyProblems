using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace compareTriplets
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int tempA, tempB;
            //int[] results;
            // initialize a list of integers

            List<int> annalice = new List<int>();
            List<int> bob = new List<int>();

            string input = "This is Alices";

            while (input != "")
            {
                Console.WriteLine("Please enter Alice integer: ");
                input = Console.ReadLine();
                if (input != "")
                {

                    annalice.Add(Convert.ToInt32(input));
                } 

                else
                {
                    Console.WriteLine("Bob's Score: ");
                     input = "His Scores";
                    while (input != "")
                    {
                        Console.WriteLine("Please enter Bob integer: ");
                        input = Console.ReadLine();
                        if (input =="")
                        {
                            List<int> result = compareTriplets(annalice, bob);
                            foreach (var item in result)
                            {
                                Console.WriteLine("The final results is " + item.ToString());
                            }
                           
                        }
                        else
                        {
                            bob.Add(Convert.ToInt32(input));

                        }
                        
                    }
                  
                }

               
            }

           


            Console.ReadLine();

        }

        private static  List<int> compareTriplets(List<int> annalice, List<int> bob)
            {
            var result = new List<int>();
            int tempA=0, tempB = 0;

            for (int i = 0; i < annalice.Count; i++)
            {

                if (annalice[i] > bob[i])
                    {
                        
                        tempA++;
                    }
                else if (annalice[i] < bob[i])
                        {
                            tempB++;
                        }
                  

            }
            result.Add(tempA);
            result.Add(tempB);

            return result;
        }
    }
}
