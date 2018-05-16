//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumericalSequence
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            if (int.TryParse(args[0], out n))
            {
                var proccessingSeries = new SeriesOutput(n);
                proccessingSeries.Print();
            }
            else
            {
                Console.WriteLine("Incorrect data!");
            }
        }
    }
}
