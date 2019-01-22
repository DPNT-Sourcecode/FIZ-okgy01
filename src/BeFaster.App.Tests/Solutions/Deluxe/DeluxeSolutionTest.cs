using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;


 namespace BeFaster.App.Tests.Solutions.Deluxe
{

    [TestFixture]
    public class DeluxeSolutionTest
    {
        [TestCase(11, ExpectedResult ="deluxe")]
        public string DeluxeTrueTest(int input) {
            return FizzBuzzSolution.FizzBuzz(input);
        }


        [TestCase(33, ExpectedResult = "fizz deluxe")]
        public string FizzDeluxeTrueTest(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }

    }
}
