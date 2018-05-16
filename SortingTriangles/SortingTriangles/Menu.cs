//---------------------------------------------
// <copyright file="Menu.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles
{
    using System;

    public class Menu
    {
        private SortingTriangles triangles = new SortingTriangles();

        public void Start()
        {

            this.AddTriangle();
            Console.WriteLine("Enter \"y\" or \"yes\" if you want to add another triangle.");
            var unswer = Console.ReadLine().ToLower();
            if (unswer == "y" || unswer == "yes")
            {
                this.Start();
            }
            else
            {
                this.triangles.SortByAreaByDescending();
                this.triangles.Print();
            }

        }

        public void AddTriangle()
        {
            try
            {
                Console.WriteLine("Enter data for triangle in such way:");
                Console.WriteLine("\t<name>, <side length>, <side length>, <side length>");
                var response = Console.ReadLine().Trim();
                string[] dataOfTriangle = response.Split(',');
                string name = dataOfTriangle[0];
                if (name == string.Empty)
                {
                    Console.WriteLine("The name hadn't be empty!");
                    this.AddTriangle();
                }
                else
                {
                    var a = Convert.ToDouble(dataOfTriangle[1]);
                    var b = Convert.ToDouble(dataOfTriangle[2]);
                    var c = Convert.ToDouble(dataOfTriangle[3]);
                    this.triangles.ListOfTriangles.Add(new Triangle(name, a, b, c));
                }         
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