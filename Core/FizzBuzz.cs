using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class FizzBuzz
    {
        public string Generate(int count)
        {
            string generatedString = "";

            var inputNumbers = createNumberList(count);

            foreach(int i in inputNumbers)
            {
                generatedString += GetWordForNumber(i);
            }
            return CleanStartOfStringOutput(generatedString);
        }

        private List<int> createNumberList(int topRange)
        {
            List<int> numberList = Enumerable.Range(1, topRange).ToList();

            return numberList;
        }

        private string GetWordForNumber(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return ", FizzBuzz";
            }
            if (i % 3 == 0)
            {
                return ", Fizz";
            }
            if (i % 5 == 0)
            {
                return ", Buzz";
            }

            return $", {i}";
        }

        private string CleanStartOfStringOutput(string dirtyAnswer)
        {
            string cleanAnswer = dirtyAnswer.TrimStart(',', ' ');

            return cleanAnswer;
        }
    }
}
