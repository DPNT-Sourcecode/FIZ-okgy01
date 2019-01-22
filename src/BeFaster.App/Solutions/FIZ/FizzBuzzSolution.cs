using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {


            int ofThree = number ^ 3;
            var ofFive = number ^ 5;

            if (ofThree == 0 && ofFive == 0) {
                return "fizz buzz";
            }else if (ofFive== 0 && ofThree != 0) {
                return "buzz";
            }else if (ofFive !=0  && ofThree == 0) {
                return "fizz";
            }else
            {
                return number.ToString();
            }





        }
    }
}

