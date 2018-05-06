//---------------------------------------------
// <copyright file="Triangle.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles
{
    using System;

    /// <summary>
    /// Contains basic logic for triangle.
    /// </summary>
    public class Triangle : ITriangle
    {
        #region
        /// <summary>
        /// name of triangle.
        /// </summary>
        private string name;

        /// <summary>
        /// First side of triangle.
        /// </summary>
        private double a;

        /// <summary>
        /// Second side of triangle.
        /// </summary>
        private double b;

        /// <summary>
        /// Third side of triangle.
        /// </summary>
        private double c;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="name">Name of triangle.</param>
        /// <param name="a">First side of triangle.</param>
        /// <param name="b">Second side of triangle.</param>
        /// <param name="c">Third side of triangle.</param>
        public Triangle(string name, double a, double b, double c)
        {
            this.name = name;
            this.a = Math.Abs(a);
            this.b = Math.Abs(b);
            this.c = Math.Abs(c);       
        }

        /// <summary>
        /// Gets name of triangle.
        /// </summary>
        public string Name { get => this.name; }

        /// <summary>
        /// Returns "true", if triangle exist.
        /// </summary>
        /// <returns>if triangle exist.</returns>
        public bool IsTriangleExist() => ((this.a + this.b > this.c) && 
                                           (this.a + this.c > this.b) &&
                                            (this.b + this.c > this.a));

        /// <summary>
        /// Gets an area of triangle.
        /// </summary>
        /// <returns>Area of triangle.</returns>
        public double Area()
        {
            double perimeter = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(perimeter *
                      (perimeter - this.a) *
                      (perimeter - this.b) *
                      (perimeter - this.c));
        }
    }
}
