using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallProject
{
    class Program
    {
        static string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        // Creating the static string I can eassily calling on any method
        static void Main(string[] args)
        {
            GetInches(GetYears());
        }
        // for the main void i only need call the method GetYears

        static int GetYears()
        {
            Console.WriteLine("\n\nPlease enter the number of years:   ");
            int numyears = (int.Parse(Console.ReadLine()));
            return numyears;

        }
        // on this method is possible do count of years
        static void GetInches(int years)
        {
            double inches;
            double average = 0;
            double totalInches = 0;

            for (int j = 0; j < years; j++)
            {
                for (int i = 0; i < Months.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\n How many inches of rainfaal for " + Months[i] + ": ");
                    inches = double.Parse(Console.ReadLine());

                    totalInches += inches;

                }
            }
            //this metthod do the loop foi any month of the year and storege the data dor the rainfall.
            average = totalInches / (years * Months.Length);
            // this give the finall result
            Console.WriteLine("RESULT: " + average);
            Console.ReadLine();
        }
    }
}

