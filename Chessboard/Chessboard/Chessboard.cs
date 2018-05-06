//---------------------------------------------
// <copyright file="Chessboard.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace Chessboard
{
    using System;

    /// <summary>
    /// Contains the basic logic for creating a field. 
    /// </summary>
    public class Chessboard
    {      
        /// <summary>
        /// Count of cells in height.
        /// </summary>
        private int height;

        /// <summary>
        /// Count of cells in width.
        /// </summary>
        private int width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chessboard"/> class.
        /// </summary>
        /// <param name="height">Count of cells in height.</param>
        /// <param name="width">Count of cells in width.</param>
        public Chessboard(int height, int width)
        {
            this.height = Math.Abs(height);
            this.width = Math.Abs(width);
            if (this.width > 79)
            {
                this.width = 79;
            }
        }

        /// <summary>
        /// Gets representation of field.
        /// </summary>
        /// <returns>The field.</returns>
         public string GetField()
        {
            if ((this.width == 0) || (this.height == 0))
            {
                return string.Empty;
            }

            string oddRow = $"{this.ConcatString("*", " ", this.width)}\n";
            string evenRow = $"{this.ConcatString(" ", "*", this.width)}\n";
            return this.ConcatString(oddRow, evenRow, this.height);
        }

        /// <summary>
        /// Concatenate odd and even value specified number of times (length).
        /// </summary>
        /// <param name="oddValue">Odd value.</param>
        /// <param name="evenValue">Even value.</param>
        /// <param name="length">Number of times for concatenation.</param>
        /// <returns>Concatenation of odd and even value.</returns>
        private string ConcatString(string oddValue, string evenValue, int length)
        {
            string representation = string.Empty;
            for (var i = 0; i < length - 1; i += 2)
            {
                representation += $"{oddValue}{evenValue}";
            }

            representation += (length % 2 == 0) ? string.Empty : $"{oddValue}";
            return representation;
        }
    }
}
