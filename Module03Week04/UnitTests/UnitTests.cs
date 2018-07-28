using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace UnitTests
{
    class UnitTests
    {
        [TestFixture]
        public class UnitTest
        {
            private int _testResult;

            [TestCase]
            public void StringCalculator_EmptyString_ReturnsZero()
            {
                _testResult = MethodLibrary.StringCalculator.Add("");

                Assert.AreEqual(_testResult, 0);
            }

            [TestCase]
            public void StringCalculator_StringEquals_One_ReturnsOne()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1");

                Assert.AreEqual(_testResult, 1);
            }

            [TestCase]
            public void StringCalculator_StringContains_OneAndTwo_ReturnsThree()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1,2");

                Assert.AreEqual(_testResult, 3);
            }

            [TestCase]
            public void StringCalculator_StringContains_ALotOfNumbers()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1,2,2,10,3,6,5");

                Assert.AreEqual(_testResult, 29);
            }

            [TestCase]
            public void StringCalculator_StringContains_NewLineDelimiter()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1\n2,3");

                Assert.AreEqual(_testResult, 6);
            }

            [TestCase]
            public void StringCalculator_StringContains_NumberOne_AComma_AndANewLineDelimiter()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1,\n");

                Assert.AreEqual(_testResult, 1);
            }

            [TestCase]
            public void StringCalculator_StringContains_CustomDelimiter()
            {
                _testResult = MethodLibrary.StringCalculator.Add("//;\n1;2");

                Assert.AreEqual(_testResult, 3);
            }

            [TestCase]
            public void StringCalculator_StringContains_NegativeNumber_And_Throws_Exception()
            {
                try
                {
                    _testResult = MethodLibrary.StringCalculator.Add("//;\n1;-2");
                }
                catch (System.Exception e)
                {
                    Assert.AreEqual(e.Message, "Negatives not allowed -2");
                }
            }
        }
    }
}
