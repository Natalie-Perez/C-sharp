using System;
using System.Collections.Generic;

namespace hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Rectangle Dimensions */
            int x = 4;
            int y = 5;
            int area = rectArea(x , y);
            
            Console.WriteLine("The area of the rectangle is "+ area + "\n");





            /**** Multiplication Table ****/
            int m = 5;
            multiplyTable(m);

            // For terminal formatting purposes only
            Console.WriteLine();





            /**** Max ****/
            int[] array = {1, 5, 3, 20, 10, 2, 1, 15};
            max(array);

            // For terminal formatting purposes only
            Console.WriteLine();




            
            /**** Increase salaries by 10% ****/
            double Salary = 50000;
            increaseTen(Salary);
            
            // For terminal formatting purposes only
            Console.WriteLine();
        }




        /***** Functions ****/

        public static int rectArea(int l, int w)
        {
            // Area of a rectange = Length * Width
            int area = (l * w);
            return area;
        }

        public static void multiplyTable(int n)
        {
            // Columns
            for (int y = 1; y <= n; y++)
            {
                // Rows
                for(int x = 1; x <= n; x++)
                {
                    int mult = x * y;
                    
                    // align the way table prints
                    if(mult < 10)
                    {
                        Console.Write(mult + "   ");
                    }
                    else
                    {
                        Console.Write(mult + "  ");
                    }
                }
                // End of row: Line break for new row
                Console.WriteLine();
            }
        } 


        public static void max(int[] array)
        {
            int biggestValue  = array[0];

            for(int i = 0; i < (array.Length - 1); i++)
            {

                int next = array[i + 1];
                if(biggestValue < next)
                {
                    biggestValue = next;
                }             

            }
            Console.WriteLine("Biggest value is: " + biggestValue);
        }


        public static void increaseTen(double s)
        {
            double tenPercent = (s * 0.10);
            double newSalary = s + tenPercent; 
            Console.WriteLine("\n" + "Old Salary: {0:C2}", s);
            Console.WriteLine("New Salary: {0:C2}", newSalary);
        }
    }
}