/*
Author: Richard Mora
Date: 10/9/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, problem 2 Iteration Constructs

region 1: print 1-5 with spaces in between on a single line using a for loop

region 2: print 1-5 with spaces in between on a single line using a while loop

region 3: print 1-5 with spaces in between on a single line using a do/while loop
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
            //Input: Create objects that is an integer data type, each has a value of 1 while inside 3 different loops.

            //Output: For the 3 loops when executed, each will print out the numbers 1 through 5 in a single line with spaces in between each number.

            //Behavior: Each loop will have an object with a value of 1 (i, count for example), as long as that value is
            //less than 6 the loop will execute over and over again while adding 1 to that value (1 becomes 2 and starts 
            //loop over again). This will continue until each object is no longer less than 6 then the loop ends. 
        {
            // this region name is for loop
            #region for loop
            // this creates a for loop where we create an object i with a int data type that has a value of 1. The condition is as long i is less than 6 the loop will 
            //contiune to run and increase by one each time the loop executes until the condition is no longer true.
            for (int i = 1; i < 6; i++)
            {
                // Console.Write() prints out anything inside () on a single line. In this case, we print out the value of i following a space (ex: 1 2...)
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            #endregion

            // this region name is while loop
            #region while loop
            // we start by creating an object Count that has a int data type and give it a value of 1.
            int Count = 1;
            // we start a while loop where as long as Count is less than 6, the loop will contiune to execute until the condition is no longer true.
            while (Count < 6)
            {
                // Same as with the for loop, Console.Write() prints out anything inside (). in this case, prints out the value of Count following a space in one line.
                Console.Write("{0} ", Count);

                // After the while loop execute a loop, we use Count++ to add 1 to the value of Count. This will cause the value of Count to increase in value until it becomes 6 which cause the condition above to be false otherwise the while loop will keep executing causing a infinite loop. 
                Count++;
            }
            Console.WriteLine();
            #endregion

            // this region name is do/while loop
            #region do/while loop
            // we start by creating an int data type count with a value of 1
            int count = 1;
            // the do loop will execute the code inside the {} as long as the condition in the while line is no longer true
            do
            {
                // we use console write to print count on a single line with a space in between 
                Console.Write("{0} ", count);
                // at the end of each loop we add 1 to the value of count
                count++;
            }
            // the while line is the condition to the do loop, as long as this condition is true, the do/while loop will continue to execute.
            while (count < 6);
            Console.WriteLine();
            #endregion
        }
    }
}
