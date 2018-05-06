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
    using System.Linq;

    /// <summary>
    /// Contains basic logic of list of triangles
    /// </summary>
    public class Triangles
    {
        /// <summary>
        /// List of triangles.
        /// </summary>
        private List<ITriangle> listOfTriangle = new List<ITriangle>();

        /// <summary>
        /// Gets list of triangles.
        /// </summary>
        public List<ITriangle> ListOfTriangle { get => this.listOfTriangle; }

        /// <summary>
        /// Adds triangle to list.
        /// </summary>
        /// <param name="triangle">Given triangle.</param>
        public void AddTriangle(ITriangle triangle)
        {
            if (triangle.IsTriangleExist())
            {
                this.listOfTriangle.Add(triangle);
            }
            else
            {
                throw new Exception("Triangle doesn't exist!");
            }
        }

        /// <summary>
        /// Sorts list of triangles.
        /// </summary>
        /// <returns>Sort list of triangles </returns>
        public List<ITriangle> Sort() => this.listOfTriangle.OrderByDescending((triangle) => triangle.Area()).ToList();

        /// <summary>
        /// Print sort list of triangles.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("============= Triangles list: ===============");
            int index = 0;
            foreach (var triangle in this.listOfTriangle)
            {
                Console.WriteLine($"{++index}. [{triangle.Name}] : {triangle.Area():f3} cm");
            }          
        }
    }
}
