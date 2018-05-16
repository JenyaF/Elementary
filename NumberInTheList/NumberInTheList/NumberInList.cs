namespace NumberInTheList
{
    using System.Collections.Generic;

    public class NumberInList
    {
        private readonly int number;

        public NumberInList(int number)
        {
            this.number = number;
        }

        public string GetStringNumber()
        {
            string digitString;
            if (number == 0)
            {
                digitString = "ноль";
            }
            else
            {
                var units = new Units();
                units.QueueDigits = GetQueueOfDigits();
                units.StackStringDigits = new Stack<string>();
                digitString = units.Extract();
            }

            return digitString;
        }

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
