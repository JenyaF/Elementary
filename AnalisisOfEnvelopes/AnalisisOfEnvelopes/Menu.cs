//---------------------------------------------
// <copyright file="Menu.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace AnalisisOfEnvelopes
{
    using System;

    /// <summary>
    /// Contains basic logic for menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Starts menu.
        /// </summary>
        public void Start()
        {
            while (true)
            {
                double a = this.GetRequest();
                double b = this.GetRequest();
                double c = this.GetRequest();
                double d = this.GetRequest();
                InsertingEnvelopes insertingEnvelopes = new InsertingEnvelopes(a, b, c, d);
                Console.WriteLine(insertingEnvelopes.IsInsertingEnvelopes());
                Console.WriteLine("Enter \"y\" or \"yes\" if you want to continue working with envelope.");
                string unswer = Console.ReadLine().ToLower();
                if (unswer == "y" || unswer == "yes")
                {
                    this.Start();
                }
                else
                {
                    break;
                }
            }           
        }

        /// <summary>
        /// Gets side of envelope.
        /// </summary>
        /// <returns>side of envelope.</returns>
        public double GetRequest()
        {
            try
            {
                Console.WriteLine("Enter side of envelope:");
                double x = Convert.ToDouble(Console.ReadLine());
                if (x > 0)
                {
                    return x;
                }

                throw new Exception("Side must be greater then zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect data!");
            }
            catch (Exception e)
            {               
                Console.WriteLine(e.Message);
            }

            return this.GetRequest();
        }     
    }
}
