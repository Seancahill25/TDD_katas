using System;
using NUnit.Framework;

namespace String_Calculator.Tests
{
    public class StringCalculatorTests
    {
        [Test]
        public void EmptyStringReturnsZero()
        {
            var input = "";
            var output = StringCalculator.Calculate(input);
            Assert.AreEqual(output, 0);
        }
        [Test]
        public void SingleNumberReturnsValue()
        {
            var input = "8";
            var output = StringCalculator.Calculate(input);
            Assert.AreEqual(8, output);
        }
        [Test]
        public void TwoNumbersCommaDelimitedReturnsSum()
        {
            var input = "8,2";
            var output = StringCalculator.Calculate(input);
            Console.WriteLine(output);
            Assert.AreEqual(output, 10);
        }
        [Test]
        public void TwoNumbersNewLineDelimitedReturnsSum()
        {
            var input = "8\n2";
            var output = StringCalculator.Calculate(input);
            Console.WriteLine(output);
            Assert.AreEqual(output, 10);
        }
    }
}