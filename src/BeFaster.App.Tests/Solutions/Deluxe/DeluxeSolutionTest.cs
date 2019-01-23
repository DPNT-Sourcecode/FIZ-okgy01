using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;


 namespace BeFaster.App.Tests.Solutions.Deluxe
{

    [TestFixture]
    public class DeluxeSolutionTest
    {
        //[TestCase(11, ExpectedResult ="deluxe")]
        //public string DeluxeTrueTest(int input) {
        //    return FizzBuzzSolution.FizzBuzz(input);
        //}


        [TestCase(222, ExpectedResult = "fizz deluxe")]
        public string FizzDeluxeTrueTest(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }

        [TestCase(3, ExpectedResult = "fizz")]
        public string FizzTestTrue(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }

        [TestCase(5, ExpectedResult = "buzz")]
        public string BuzzTestTrue(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }

        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        public string FizzFakeDeluxeTrue(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }

        [TestCase(11, ExpectedResult = "fake deluxe")]
        public string FakeDeluxeTrue(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }

        [TestCase(55, ExpectedResult = "buzz fake deluxe")]
        public string BuzzFakeDeluxeTrue(int input)
        {
            return FizzBuzzSolution.FizzBuzz(input);
        }



    }
}



