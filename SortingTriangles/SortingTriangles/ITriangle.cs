//---------------------------------------------
// <copyright file="ITriangle.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------
namespace SortingTriangles
{
    /// <summary>
    /// Interface for triangle
    /// </summary>
    public interface ITriangle
    {
        /// <summary>
        /// Gets name of triangle.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Returns "true", if triangle exist.
        /// </summary>
        /// <returns>if triangle exist.</returns>
        bool IsTriangleExist();

        /// <summary>
        /// Gets an area of triangle.
        /// </summary>
        /// <returns>Area of triangle.</returns>
        double Area();
    }
}
