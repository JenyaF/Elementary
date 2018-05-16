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
            int n = Convert.ToInt32(args[0]);
            SeriesOutput proccessingSeries = new SeriesOutput(n);
            proccessingSeries.Print();
        }
    }
}
