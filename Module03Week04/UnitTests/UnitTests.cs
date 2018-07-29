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

                Assert.AreEqual(0, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringEquals_One_ReturnsOne()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1");

                Assert.AreEqual(1, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringContains_OneAndTwo_ReturnsThree()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1,2");

                Assert.AreEqual(3, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringContains_ALotOfNumbers()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1,2,2,10,3,6,5");

                Assert.AreEqual(29, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringContains_NewLineDelimiter()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1\n2,3");

                Assert.AreEqual(6, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringContains_NumberOne_AComma_AndANewLineDelimiter()
            {
                _testResult = MethodLibrary.StringCalculator.Add("1,\n");

                Assert.AreEqual(1, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringContains_CustomDelimiter()
            {
                _testResult = MethodLibrary.StringCalculator.Add("//;\n1;2");

                Assert.AreEqual(3, _testResult);
            }

            [TestCase]
            public void StringCalculator_StringContains_NegativeNumber_And_Throws_Exception()
            {
                try
                {
                    _testResult = MethodLibrary.StringCalculator.Add("//;\n1;-2");
                }
                catch (Exception e)
                {
                    Assert.AreEqual("Negatives not allowed -2", e.Message);
                }
            }
        }
    }
}
