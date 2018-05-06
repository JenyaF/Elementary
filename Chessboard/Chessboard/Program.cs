//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace Chessboard
{
    using System;

    /// <summary>
    /// Class for starting program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starts program.
        /// </summary>
        /// <param name="args">Arguments that are passed at startup.</param>
        public static void Main(string[] args)
        {
            int height = Convert.ToInt32(args[0]);
            int width = Convert.ToInt32(args[1]);
            Chessboard chessboard = new Chessboard(height, width);
            Console.WriteLine(chessboard.GetField());
        }
    }
}
