//---------------------------------------------
// <copyright file="Triangle.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace SortingTriangles
{
    using System;

    public class Triangle 
    {
        private readonly string name;
        /// <summary>
        /// First side of triangle.
        /// </summary>
        private readonly double a;
        /// <summary>
        /// Second side of triangle.
        /// </summary>
        private readonly double b;
        /// <summary>
        /// Third side of triangle.
        /// </summary>
        private readonly double c;

        public Triangle(string name, double a, double b, double c)
        {          
            this.a = Math.Abs(a);
            this.b = Math.Abs(b);
            this.c = Math.Abs(c); 
            if(!IsTriangleExist())
            {
                throw new Exception("Triangle doesn't exist!");
            }
            this.name = name;
        }

        public string Name { get => this.name; }

        public double GetArea()
        {
            double perimeter = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(perimeter *
                      (perimeter - this.a) *
                      (perimeter - this.b) *
                      (perimeter - this.c));
        }
        
        private bool IsTriangleExist() => ((this.a + this.b > this.c) && 
                                           (this.a + this.c > this.b) &&
                                            (this.b + this.c > this.a));
    }
}
