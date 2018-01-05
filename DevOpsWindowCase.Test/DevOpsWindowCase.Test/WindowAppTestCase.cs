using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace DevOpsWindowCase.Test
{
    [TestFixture]
    public class WindowAppTestCase
    {

        [TestCase]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(20, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        public void DivisonTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Division(20, 10);
            Assert.AreEqual(2, result);
        }

        [TestCase]
        public void MultiplicationTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Multiplication(20, 10);
            Assert.AreEqual(200, result);
        }
    }
}
