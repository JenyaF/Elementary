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

    public class Menu
    {
        private string[] dataOfResponse;

        public static string GetInstruction()
        {
            return "Enter one of the following options:\n\n" +
                " <Chessboard> <height> <width> \n" +
                "\t Displays a chessboard with the given dimensions of height and width.\n" +
                "<Envelopes>\n" +
                "\t Finds out if one envelope can be put in another.\n" +
                "<Triangles>\n" +
                "\t Displays of triangles in descending order of their area\n" +
                "<FileParser> <path to file> <string for counting>\n" +
                "\t Read the number of occurrences of a string in a text file.\n" +
                "<FileParser> < path to file> < string to search> < string to replace>\n" +
                "\t Replace the string with another in the specified file.\n" +
                "<NumberInTheList> <number>" +
                "\t Convert an integer to the list.\n" +
                "<Tickets> <path to file>\n" +
                "\t Count the number of happy tickets in the Piter and Moskow way.\n" +
                "<NumericalSequence> <n>\n" +
                "\t Displays a series of natural numbers, the square of which is less than the given number n.\n" +
                "<Fibonacci> <lower bound> <upper bound>\n" +
                "\t Output all Fibonacci numbers that are in the specified range.";
        }

        public void Start()
        {
            try
            {
                Console.WriteLine("Enter name of task with params:");
                string responce = Console.ReadLine().Trim();
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

                        case "envelopes":
                            {
                                this.ProceedTask(0, AnalisisOfEnvelopes.Program.Main);
                                break;
                            }

                        case "triangles":
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
                                    Console.WriteLine("Number of params must be 2 or 3!");
                                    this.Start();
                                }

                                break;
                            }

                        case "numbersinthelist":
                            {
                                this.ProceedTask(1, NumberInTheList.Program.Main);
                                break;
                            }

                        case "tickets":
                            {
                                this.ProceedTask(1, HappyTickets.Program.Main);
                                break;
                            }

                        case "numericalsequence":
                            {
                                this.ProceedTask(1, NumericalSequence.Program.Main);
                                break;
                            }

                        case "fibonacci":
                            {
                                this.ProceedTask(2, FibonacciSeriesforRange.Program.Main);
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Incorrect name of task!");
                                this.Start();
                                break;
                            }
                    }

                    Console.WriteLine("Enter \"y\" or \"yes\" if you want to continue to choose task.");
                    string unswer = Console.ReadLine().ToLower();
                    if (unswer == "y" || unswer == "yes")
                    {
                        this.Start();
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

        private void ProceedTask(int countOfParams, Action<string[]> action)
        {
            if (this.dataOfResponse.Length - 1 == countOfParams)
            {
                action(this.dataOfResponse.Skip(1).ToArray());
            }
            else
            {
                Console.WriteLine($"count of params must be { countOfParams}!");
                this.Start();
            }
        }
    }
}
