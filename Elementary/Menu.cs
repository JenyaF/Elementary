//---------------------------------------------
// <copyright file="Menu.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace Elementary
{
    using System;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Contains basic logic for menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Data of response
        /// </summary>
        private string[] dataOfResponse;

        /// <summary>
        /// Gets instruction.
        /// </summary>
        /// <returns>Instruction for using.</returns>
        public static string GetInstruction()
        {
            string instruction = string.Empty;

            return "Enter one of the following options:\n\n" +
                " <Chessboard> <height> <width> \n" +
                "\t Displays a chessboard with the given dimensions of height and width.\n" +
                "<AnalisisOfEnvelopes>\n" +
                "\t Finds out if one envelope can be put in another.\n" +
                "<SortingTriangles>\n" +
                "\t Displays of triangles in descending order of their area\n" +
                "<FileParser> <path to file> <string for counting>\n" +
                "\t Read the number of occurrences of a string in a text file.\n" +
                "<FileParser> < path to file> < string to search> < string to replace>\n" +
                "\t Replace the string with another in the specified file.\n" +
                "<NumberInTheList> <number>" +
                "\t Convert an integer to the list.\n" +
                "<HappyTickets> <path to file>\n" +
                "\t Count the number of happy tickets in the Piter and Moskow way.\n" +
                "<NumericalSequence> <n>\n" +
                "\t Displays a series of natural numbers, the square of which is less than the given number n.\n" +
                "<FibonacciSeriesforRange> <lower bound> <upper bound>\n" +
                "\t Output all Fibonacci numbers that are in the specified range.";
        }

        /// <summary>
        /// Starts menu.
        /// </summary>
        public void Start()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter name of task with params:");
                    string responce = Console.ReadLine().TrimStart().TrimEnd();
                    if (responce == string.Empty)
                    {
                        Console.WriteLine(GetInstruction());
                    }
                    else
                    {
                        this.dataOfResponse = responce.Split(' ');
                        switch (this.dataOfResponse[0].ToLower())
                        {
                            case "":
                                {
                                    Console.WriteLine(GetInstruction());
                                    break;
                                }

                            case "chessboard":
                                {
                                    this.ProceedTask(2, Chessboard.Program.Main);
                                    break;
                                }

                            case "analisisofenvelopes":
                                {
                                    this.ProceedTask(0, AnalisisOfEnvelopes.Program.Main);
                                    break;
                                }

                            case "sortingtriangles":
                                {
                                    this.ProceedTask(0, SortingTriangles.Program.Main);
                                    break;
                                }

                            case "fileparser":
                                {
                                    if ((this.dataOfResponse.Length - 1 == 2) || (this.dataOfResponse.Length - 1 == 3)) 
                                    {
                                        FileParser.Program.Main(this.dataOfResponse.Skip(1).ToArray());
                                    }
                                    else
                                    {
                                        throw new Exception($"count of params must be 2 or 3!");
                                    }

                                    break;
                                }

                            case "numberinthelist":
                                {
                                    this.ProceedTask(1, NumberInTheList.Program.Main);
                                    break;
                                }

                            case "happytickets":
                                {
                                    this.ProceedTask(1, HappyTickets.Program.Main);
                                    break;
                                }

                            case "numericalsequence":
                                {
                                    this.ProceedTask(1, NumericalSequence.Program.Main);
                                    break;
                                }

                            case "fibonacciseriesforrange":
                                {
                                    this.ProceedTask(2, FibonacciSeriesforRange.Program.Main);
                                    break;
                                }

                            default:
                                {
                                    throw new Exception("Incorrect name of task!");                                    
                                }
                        }

                        Console.WriteLine("Enter \"y\" or \"yes\" if you want to continue to choose task.");
                        string unswer = Console.ReadLine().ToLower();
                        if (unswer == "y" || unswer == "yes")
                        {
                            this.Start();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect data!");
                this.Start();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesn't exist!");
                this.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.Start();
            }
        }

        /// <summary>
        /// Proceed task
        /// </summary>
        /// <param name="countOfParams">Count of parameters.</param>
        /// <param name="action">Given task</param>
        private void ProceedTask(int countOfParams, Action<string[]> action)
        {
            if (this.dataOfResponse.Length - 1 == countOfParams)
            {
                action(this.dataOfResponse.Skip(1).ToArray());
            }
            else
            {
                throw new Exception($"count of params must be {countOfParams}!");
            }
        }
    }
}
