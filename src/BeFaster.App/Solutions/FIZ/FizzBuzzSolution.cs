﻿using BeFaster.Runner.Exceptions;

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


        static bool IsDeluxe(int input) {

            //1st test, if number < 10 then exit now.
            if (input < 10) {
                return false;
            }
            else {

                var retval = false;
                var test = input.ToString();

                for (var i = 1; i < test.Length; i++)
                {

                    if (test.Substring(i) == test.Substring(i - 1))
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



    }
}

