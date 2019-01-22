using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {


            int ofThree = number % 3;
            var ofFive = number % 5;

            if ((ofThree == 0 || number.ToString().Contains("3"))  && (ofFive == 0 || number.ToString().Contains("5")  )) {
                return "fizz buzz";
            }else if ((ofFive == 0 || number.ToString().Contains("5") ) && ofThree != 0) {
                return "buzz";
            }else if (ofFive !=0  && (ofThree == 0 || number.ToString().Contains("3"))) {
                return "fizz";
            }else
            {
                return number.ToString();
            }





        }
    }
}



