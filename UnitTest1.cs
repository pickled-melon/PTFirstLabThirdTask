using NUnit.Framework;
using NUnit.Framework.Legacy;
using PTFirstLabThirdTask;

namespace PTFirstLabThirdTask
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("1+2+3+4+5+6+7+8+9", ExpectedResult = 45)]
        [TestCase("-1-2-3-4-5-6", ExpectedResult = -21)]
        [TestCase("1-2-3-4-5-6", ExpectedResult = -19)]
        [TestCase("0+0-0+0-0+0", ExpectedResult = 0)]
        [TestCase("1-1+1-1+1-1", ExpectedResult = 0)]
        [TestCase("-1+-+20", ExpectedResult = 19)]
        [TestCase("23", ExpectedResult = 23)]
        [TestCase("12+23+fwefe-ffeef+89", ExpectedResult = 124)]
        public int GetSumOfNumbersInText(string inputText) 
        {
            return Logic.GetSumOfNumbersInText(inputText);
        }
    }
}
