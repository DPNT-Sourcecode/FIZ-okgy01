using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {


            int ofThree = number % 3;
            var ofFive = number % 5;
            if (IsDeluxe(number)==true && IsFakeDeluxe(number) == false && (ofThree == 0 || number.ToString().Contains("3")) && (ofFive == 0 || number.ToString().Contains("5")))
            {
                return "fizz buzz deluxe";
            }else if ((ofThree == 0 || number.ToString().Contains("3"))  && (ofFive == 0 || number.ToString().Contains("5")  )) {
                return "fizz buzz";
            }
            else if ((ofFive == 0 || number.ToString().Contains("5") && IsDeluxe(number) == true) && ofThree != 0 && IsDeluxe(number) == true)
            {
                return "buzz deluxe";
            }


            else if ((ofFive == 0 || number.ToString().Contains("5") && IsDeluxe(number) == false) && ofThree != 0 ) {
                return "buzz";
            }
            else if (ofFive != 0 && ((ofThree == 0 || number.ToString().Contains("3")) && IsDeluxe(number) == true))
            {
                return "fizz deluxe";

            }


            else if (ofFive !=0  && (ofThree == 0 || number.ToString().Contains("3") && IsDeluxe(number)==false)) {
                return "fizz";
            }
            else if (IsDeluxe(number) == true  && IsFakeDeluxe(number)==false  && (ofThree != 0 || !number.ToString().Contains("3")) && (ofFive != 0 || !number.ToString().Contains("5")))
            {
                return "deluxe";
            }

           
            else
            {
                return number.ToString();
            }


        }


        static bool IsDeluxe(int input) {

            //1st test, if number < 10 then exit now.
            if (input < 10) {
                return false;
            }else if (input % 2 != 0) {
                return false;
            }
            else {

                var retval = false;
                var test = input.ToString();

                for (var i = 1; i < test.Length; i++)
                {

                    if (test.Substring(i,1) == test.Substring((i - 1),1))
                    {
                        retval = true;
                    }
                    else {
                        return false;
                    }


                }


                return retval;

            }

        }


        static bool IsFakeDeluxe(int input)
        {

            //1st test, if number < 10 then exit now.
            if (input > 10 && input % 2 != 0)
            
            {

                var retval = false;
                var test = input.ToString();

                for (var i = 1; i < test.Length; i++)
                {

                    if (test.Substring(i, 1) == test.Substring((i - 1), 1))
                    {
                        retval = true;
                    }
                    else
                    {
                        return false;
                    }


                }


                return retval;

            }
            else {
                return false;
            }

        }



    }
}

