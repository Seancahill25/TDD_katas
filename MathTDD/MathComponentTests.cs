using System;
using MathComponents;
using NUnit.Framework;

namespace MathTestProject
{
    class Test
    {
        [Test]
        public void TestCaseAdd()
        {
            MathComponent obj = new MathComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void TestCaseSubtract()
        {
            MathComponent obj = new MathComponent();
            int result = obj.Subtract(10, 9);
            Assert.AreEqual(1, result);
        }
    }
}