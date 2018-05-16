//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            if (int.TryParse(args[0], out number))
            {
                var numberInList = new NumberInList(number);
                Console.WriteLine(numberInList.GetStringNumber());
            }
            else
            {
                Console.WriteLine("incorrect data!");
            }
        }
    }
}
