//---------------------------------------------
// <copyright file="Menu.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace AnalisisOfEnvelopes
{
    using System;

    public class Menu
    {
        public void Start()
        {
            double a = this.GetSideOfEnvelope();
            double b = this.GetSideOfEnvelope();
            double c = this.GetSideOfEnvelope();
            double d = this.GetSideOfEnvelope();
            var insertingEnvelopes = new InsertingEnvelopes(a, b, c, d);
            Console.WriteLine(insertingEnvelopes.IsInsertingEnvelopes());
            Console.WriteLine("Enter \"y\" or \"yes\" if you want to continue working with envelope.");
            string unswer = Console.ReadLine().ToLower();
            if (unswer == "y" || unswer == "yes")
            {
                this.Start();
            }
        }

        public double GetSideOfEnvelope()
        {
            try
            {
                Console.WriteLine("Enter side of envelope:");
                double x;
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    if (x > 0)
                    {
                        return x;
                    }
                    else
                    {
                        Console.WriteLine("Side must be greater then zero!");
                        return this.GetSideOfEnvelope();
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect data!");
                    return this.GetSideOfEnvelope();
                }
            }
            catch (Exception)
            {               
                Console.WriteLine("This is not supported!");
                return this.GetSideOfEnvelope();
            }
        }     
    }
}
