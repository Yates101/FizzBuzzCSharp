using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace UnitTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void List_Numbers_Up_To_One()
        {
            var Expected = "1";

            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.Generate(1);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void List_Numbers_Up_To_Two()
        {
            var Expected = "1, 2";

            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.Generate(2);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void Can_Replace_Multiples_Of_Three_With_Fizz()
        {
            var Expected = "1, 2, Fizz";

            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.Generate(3);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void Can_Replace_Multiples_Of_Five_With_Buzz()
        {
            var Expected = "1, 2, Fizz, 4, Buzz";

            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.Generate(5);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void Can_Replace_Multiples_Of_Three_And_Five_With_FizzBuzz()
        {

            var Expected = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11," +
                " Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, " +
                "23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, " +
                "34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, " +
                "FizzBuzz, 46, 47, Fizz, 49, Buzz, Fizz, 52, 53, Fizz, Buzz, " +
                "56, Fizz, 58, 59, FizzBuzz, 61, 62, Fizz, 64, Buzz, Fizz, " +
                "67, 68, Fizz, Buzz, 71, Fizz, 73, 74, FizzBuzz, 76, 77, " +
                "Fizz, 79, Buzz, Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89," +
                " FizzBuzz, 91, 92, Fizz, 94, Buzz, Fizz, 97, 98, Fizz, Buzz";

            FizzBuzz fizzBuzz = new();

            string result = fizzBuzz.Generate(100);

            Assert.AreEqual(Expected, result);
        }
    }
}
