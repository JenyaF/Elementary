//---------------------------------------------
// <copyright file="Menu.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles
{
    using System;

    /// <summary>
    /// Contains basic logic for menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// List of triangles.
        /// </summary>
        private Triangles triangles = new Triangles();

        /// <summary>
        /// Starts menu.
        /// </summary>
        public void Start()
        {
            while (true)
            {
                this.AddTriangle();
                Console.WriteLine("Enter \"y\" or \"yes\" if you want to add another triangle.");
                string unswer = Console.ReadLine().ToLower();
                if (unswer == "y" || unswer == "yes")
                {
                    this.Start();
                    return;
                }
                else
                {
                    this.triangles.Sort();
                    this.triangles.Print();
                    return;
                }
            }
        }

        /// <summary>
        /// Add triangle.
        /// </summary>
        public void AddTriangle()
        {
            try
            {
                Console.WriteLine("Enter data for triangle in such way:");
                Console.WriteLine("\t<name>, <side length>, <side length>, <side length>");
                string response = Console.ReadLine().TrimStart().TrimEnd();
                string[] dataOfTriangle = response.Split(',');
                string name = dataOfTriangle[0];
                if (name == string.Empty)
                {
                    throw new Exception("The name hadn't be empty!");
                }

                double a = Convert.ToDouble(dataOfTriangle[1]);
                double b = Convert.ToDouble(dataOfTriangle[2]);
                double c = Convert.ToDouble(dataOfTriangle[3]);
                this.triangles.AddTriangle(new Triangle(name, a, b, c));            
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect data!");
                this.AddTriangle();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Count of params must be 4");
                this.AddTriangle();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.AddTriangle();
            }
        }           
    }    
}