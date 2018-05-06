//---------------------------------------------
// <copyright file="Envelope.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace AnalisisOfEnvelopes
{
    /// <summary>
    /// Contains properties of envelope.
    /// </summary>
    public class Envelope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Envelope"/> class.
        /// </summary>
        /// <param name="a">First side.</param>
        /// <param name="b">Second side.</param>
        public Envelope(double a, double b)
        {
            if (a > b)
            {
                this.MaxSide = a;
                this.MinSide = b;
            }
            else
            {
                this.MaxSide = b;
                this.MinSide = a;
            }              
        }

        /// <summary>
        /// Gets min side.
        /// </summary>
        public double MinSide { get; }

        /// <summary>
        /// Gets max side.
        /// </summary>
        public double MaxSide { get; }
    }
}
