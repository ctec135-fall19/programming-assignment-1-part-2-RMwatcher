/*
Author: Richard Mora
Date: 10/10/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, problem 3 Decision Constructs

region 1: Create three nested loop one for each of the three conditions. 
          Using if statements to print out all possible actions base on the conditions

region 2: Create a switch statement inside a for loop which goes 
     through the number 1 to 7, every possible combination of conditions.
          Using cases to print out all possible actions base on each number
     of the for loop.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
            // Input: Create 3 nested loops, if statements, switch statement with a for loop for the
            // possible conditions. Create 5 methods to represent all 5 actions depending on one or more conditions

            // Output: Print the 3 conditions and tell us whether they are true or false for all three.
            // Print out the necessary actions depending on the state of the conditions

            // Behavior: Each region (if and switch statements) will give us a value 1 to 7 and will print 
            // out the necessary actions to take base on the numbers which represents all possible
            // combinations of all three statements and if they're true or false.
        {
            #region region 1
            Console.WriteLine("Using if statements\n");
            for (int cond1 = 0; cond1 <= 1; cond1++)
            {
                for (int cond2 = 0; cond2 <= 1; cond2++)
                {
                    for (int cond3 = 0; cond3 <= 1; cond3++)
                    {
                        if (cond1 == 0 && cond2 == 0 && cond3 == 0)
                        {
                            Console.WriteLine("Printer prints: False");
                            Console.WriteLine("Red light flashing: False");
                            Console.WriteLine("Printer is recognized: False");
                            Console.WriteLine("---------------------");
                            PowerCable();
                            PrintComputerCable();
                            PrinterSoftware();
                            Console.WriteLine();
                        }
                        
                        if (cond1 == 0 && cond2 == 0 && cond3 == 1)
                        {
                            Console.WriteLine("Printer prints: False");
                            Console.WriteLine("Red light flashing: False");
                            Console.WriteLine("Printer is recognized: True");
                            Console.WriteLine("---------------------");
                            PaperJam();
                            Console.WriteLine();
                        }
                        if (cond1 == 0 && cond2 == 1 && cond3 == 0)
                        {
                            Console.WriteLine("Printer prints: False");
                            Console.WriteLine("Red light flashing: True");
                            Console.WriteLine("Printer is recognized: False");
                            Console.WriteLine("---------------------");
                            PrintComputerCable();
                            PrinterSoftware();
                            CheckInk();
                            Console.WriteLine();
                        }
                        if (cond1 == 0 && cond2 == 1 && cond3 == 1)
                        {
                            Console.WriteLine("Printer prints: False");
                            Console.WriteLine("Red light flashing: True");
                            Console.WriteLine("Printer is recognized: True");
                            Console.WriteLine("---------------------");
                            CheckInk();
                            PaperJam();
                            Console.WriteLine();
                        }
                        if (cond1 == 1 && cond2 == 0 && cond3 == 0)
                        {
                            Console.WriteLine("Printer prints: True");
                            Console.WriteLine("Red light flashing: False");
                            Console.WriteLine("Printer is recognized: False");
                            Console.WriteLine("---------------------");
                            PrinterSoftware();
                            Console.WriteLine();
                        }
                        if (cond1 == 1 && cond2 == 0 && cond3 == 1)
                        {
                            Console.WriteLine("Printer prints: True");
                            Console.WriteLine("Red light flashing: False");
                            Console.WriteLine("Printer is recognized: True");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("No actions are required");
                            Console.WriteLine();
                        }
                        if (cond1 == 1 && cond2 == 1 && cond3 == 0)
                        {
                            Console.WriteLine("Printer prints: True");
                            Console.WriteLine("Red light flashing: True");
                            Console.WriteLine("Printer is recognized: False");
                            Console.WriteLine("---------------------");
                            PrinterSoftware();
                            Console.WriteLine();
                        }
                        if (cond1 == 1 && cond2 == 1 && cond3 == 1)
                        {
                            Console.WriteLine("Printer prints: True");
                            Console.WriteLine("Red light flashing: True");
                            Console.WriteLine("Printer is recognized: True");
                            Console.WriteLine("---------------------");
                            CheckInk();
                            Console.WriteLine("\n\n");
                       
                        }
                    }
                }
            }
            #endregion

            #region region 2
            Console.WriteLine("Using switch statements\n");
            for (int i = 0; i <= 7; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Printer prints: False");
                        Console.WriteLine("Red light flashing: False");
                        Console.WriteLine("Printer is recognized: False");
                        Console.WriteLine("---------------------");
                        PowerCable();
                        PrintComputerCable();
                        PrinterSoftware();
                        Console.WriteLine();
                        break;

                    case 1:
                        Console.WriteLine("Printer prints: False");
                        Console.WriteLine("Red light flashing: False");
                        Console.WriteLine("Printer is recognized: True");
                        Console.WriteLine("---------------------");
                        PaperJam();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Printer prints: False");
                        Console.WriteLine("Red light flashing: True");
                        Console.WriteLine("Printer is recognized: False");
                        Console.WriteLine("---------------------");
                        PrintComputerCable();
                        PrinterSoftware();
                        CheckInk();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Printer prints: False");
                        Console.WriteLine("Red light flashing: True");
                        Console.WriteLine("Printer is recognized: True");
                        Console.WriteLine("---------------------");
                        CheckInk();
                        PaperJam();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Printer prints: True");
                        Console.WriteLine("Red light flashing: False");
                        Console.WriteLine("Printer is recognized: False");
                        Console.WriteLine("---------------------");
                        PrinterSoftware();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Printer prints: True");
                        Console.WriteLine("Red light flashing: False");
                        Console.WriteLine("Printer is recognized: True");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("No actions is required");
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine("Printer prints: True");
                        Console.WriteLine("Red light flashing: True");
                        Console.WriteLine("Printer is recognized: False");
                        Console.WriteLine("---------------------");
                        PrinterSoftware();
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine("Printer prints: True");
                        Console.WriteLine("Red light flashing: True");
                        Console.WriteLine("Printer is recognized: True");
                        Console.WriteLine("---------------------");
                        CheckInk();
                        Console.WriteLine();
                        break;
                }
            }
            #endregion
        }
        static void CheckInk()
        {
            Console.WriteLine("Check ink and replace if empty.");
        }

        static void PaperJam()
        {
            Console.WriteLine("Check printer for paper jam.");
        }

        static void PowerCable()
        {
            Console.WriteLine("Check to ensure power cable is connected.");
        }

        static void PrintComputerCable()
        {
            Console.WriteLine("Check to ensure cable connecting printer and computer are connected.");
        }

        static void PrinterSoftware()
        {
            Console.WriteLine("Ensure the printer software is installed.");
        }
    }
}
