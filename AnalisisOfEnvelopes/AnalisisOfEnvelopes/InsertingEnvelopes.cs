//---------------------------------------------
// <copyright file="InsertingEnvelopes.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace AnalisisOfEnvelopes
{
    using static System.Math;

    public class InsertingEnvelopes
    {

        private Envelope envelope1;
        private Envelope envelope2;

        /// <param name="a">First side of first envelope.</param>
        /// <param name="b">Second side of first envelope.</param>
        /// <param name="c">First side of second envelope.</param>
        /// <param name="d">Second side of second envelope.</param>
        public InsertingEnvelopes(double a, double b, double c, double d)
        {
            this.envelope1 = new Envelope(a, b);
            this.envelope2 = new Envelope(c, d);            
        }

        public string IsInsertingEnvelopes()
        {
            bool envelope1IsInsertedToEnvelope2 = this.Envelope2IsInsertedToEnvelope1(this.envelope2, this.envelope1);
            bool envelope2IsInsertedToEnvelope1 = this.Envelope2IsInsertedToEnvelope1(this.envelope1, this.envelope2);
            if (envelope1IsInsertedToEnvelope2 && envelope2IsInsertedToEnvelope1)
            {
                return "Each envelope can be inserted into another.";
            }

            if (envelope1IsInsertedToEnvelope2)
            {
                return "First envelope can be inserted to second.";
            }

            if (envelope2IsInsertedToEnvelope1)
            {
                return "Second envelope can be inserted to first.";
            }

            return "No envelope can be inserted into another.";
        }
       
        public bool Envelope2IsInsertedToEnvelope1(Envelope envelope1, Envelope envelope2)
        {
            double formula = ((2 * envelope1.MaxSide * envelope2.MinSide * envelope2.MaxSide) +
                             (Pow(envelope2.MaxSide, 2) - Pow(envelope2.MinSide, 2)) * Sqrt(Pow(envelope2.MinSide, 2) + 
                             Pow(envelope2.MaxSide, 2) - Pow(envelope1.MaxSide, 2))) / (Pow(envelope2.MinSide, 2) + 
                             Pow(envelope2.MaxSide, 2));
            if (((envelope1.MaxSide > envelope2.MaxSide) && (envelope1.MinSide > envelope2.MinSide)) ||
               ((envelope1.MaxSide < envelope2.MaxSide) && (envelope1.MinSide > formula)))
            {
                return true;
            }

            return false;            
        }
    }
}
