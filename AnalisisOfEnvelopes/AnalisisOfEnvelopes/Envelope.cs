//---------------------------------------------
// <copyright file="Envelope.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace AnalisisOfEnvelopes
{
    using static System.Math;

    public class Envelope
    {
        public Envelope(double a, double b)
        {
            this.MaxSide = Max(a, b);
            this.MinSide = Min(a, b);
        }

        public double MinSide { get; }
        public double MaxSide { get; }
    }
}
