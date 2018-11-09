using System;
namespace Calculator
{
    public class Calculator
    {
        private float firstNumber;
        public float FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }
        private float secondNumber;
        public float SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }
        float numberInMemory;

        public Calculator()
        {
            clear();

        }

        public void clear()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            numberInMemory = 0;
        }

        public string printToString()
        {
            string pattern = @"
                First number: {0}
                Second number: {1}
                In memory: {2}";
            string result = string.Format(pattern, FirstNumber, SecondNumber, numberInMemory);
            return result;
        }

        public float multiplyNumbers()
        {
            return firstNumber * secondNumber;
        }

        public void setFirstAndSecond(int first, int second)
        {
            FirstNumber = first;
            SecondNumber = second;
        }

        public float sumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public float sumInbetween()
        {
            if (firstNumber > secondNumber)
            {
                var temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }
            int first = Convert.ToInt32(firstNumber);
            int second = Convert.ToInt32(secondNumber);

            int sum = 0;
            for (int i = first; i < second + 1; i++)
            {
                sum += i;
            }
            return sum;
        }

        public void storeNumber(int val)
        {
            numberInMemory = val;
        }

        public void removeFromMemory()
        {
            numberInMemory = 0;
        }
    }
}

