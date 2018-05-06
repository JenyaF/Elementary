namespace NumberInTheList
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains basic logic for string representation number.
    /// </summary>
    public class NumberInList
    {
        /// <summary>
        /// Given number.
        /// </summary>
        private int number;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberInList"/> class.
        /// </summary>
        /// <param name="number">Given number.</param>
        public NumberInList(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// Gets string representation of number.
        /// </summary>
        /// <returns>String representation of number.</returns>
        public string GetStringNumber()
        {
            string digitString;
            if (number == 0)
            {
                digitString = "ноль";
            }
            else
            {
                Units units = new Units();
                units.QueueDigits = GetQueueOfDigits();
                units.StackStringDigits = new Stack<string>();
                digitString = units.Extract();
            }

            return digitString;
        }

        /// <summary>
        /// Get queue of digits of number.
        /// </summary>
        /// <returns>Queue of  digits.</returns>
        private Queue<int> GetQueueOfDigits()
        {
            var queueDigits = new Queue<int>();
            var quotient = number / 10;
            queueDigits.Enqueue(number % 10);
            while (quotient != 0)
            {
                queueDigits.Enqueue(quotient % 10);
                quotient /= 10;
            }

            return queueDigits;
        }
    }
}
