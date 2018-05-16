//---------------------------------------------
// <copyright file="Triangles.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles
{
    using System;
    using System.Collections.Generic;

    public class SortingTriangles
    {
        public List<Triangle> ListOfTriangles { get; set; } = new List<Triangle>();

        public void SortByAreaByDescending() => this.ListOfTriangles.Sort((x, y) => y.GetArea().CompareTo(x.GetArea()));

        public void Print()
        {
            Console.WriteLine("============= Triangles list: ===============");
            var index = 0;
            foreach (var triangle in this.ListOfTriangles)
            {
                Console.WriteLine($"{++index}. [{triangle.Name}] : {triangle.GetArea():f3} cm");
            }          
        }
    }
}
