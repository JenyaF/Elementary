//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace Chessboard
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int height = Convert.ToInt32(args[0]);
            int width = Convert.ToInt32(args[1]);
            if (int.TryParse(args[0], out height) && int.TryParse(args[1], out width))
            {
                var chessboard = new Chessboard(height, width);
                Console.WriteLine(chessboard.GetField());
            }
            else
            {
                Console.WriteLine("Incorrect data!");
            }
            Console.ReadLine();
        }                                      
    }
}
