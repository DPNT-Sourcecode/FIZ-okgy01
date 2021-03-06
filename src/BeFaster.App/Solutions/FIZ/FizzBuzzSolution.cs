﻿using BeFaster.Runner.Exceptions;

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
            }
            else if (IsDeluxe(number) == false && IsFakeDeluxe(number) == true && (ofThree == 0 || number.ToString().Contains("3")) && (ofFive == 0 || number.ToString().Contains("5")))
            {
                return "fizz buzz fake deluxe";
            }


            else if ((ofThree == 0 || number.ToString().Contains("3"))  && (ofFive == 0 || number.ToString().Contains("5")  )) {
                return "fizz buzz";
            }
            else if (((ofFive == 0 || number.ToString().Contains("5")) && IsDeluxe(number) == true && IsFakeDeluxe(number) == false) && ofThree != 0 )
            {
                return "buzz deluxe";
            }
            else if (((ofFive == 0 || number.ToString().Contains("5")) && IsDeluxe(number) == false && IsFakeDeluxe(number) == true) && ofThree != 0)
            {
                return "buzz fake deluxe";
            }

            else if ((ofFive == 0 || number.ToString().Contains("5") && IsDeluxe(number) == false) && ofThree != 0 ) {
                return "buzz";
            }
            else if (ofFive != 0 && ((ofThree == 0 || number.ToString().Contains("3")) && IsDeluxe(number) == true) && IsFakeDeluxe(number) == false)
            {
                return "fizz deluxe";

            }
            else if (ofFive != 0 && ((ofThree == 0 || number.ToString().Contains("3")) && IsDeluxe(number) == false) && IsFakeDeluxe(number) == true)
            {
                return "fizz fake deluxe";

            }



            else if (ofFive !=0  && (ofThree == 0 || number.ToString().Contains("3") && IsDeluxe(number)==false)) {
                return "fizz";
            }
            else if (IsDeluxe(number) == true  && IsFakeDeluxe(number)==false  && (ofThree != 0 || !number.ToString().Contains("3")) && (ofFive != 0 || !number.ToString().Contains("5")))
            {
                return "deluxe";
            }
            else if (IsDeluxe(number) == false && IsFakeDeluxe(number) == true && (ofThree != 0 || !number.ToString().Contains("3")) && (ofFive != 0 || !number.ToString().Contains("5")))
            {
                return "fake deluxe";
            }

            else
            {
                return number.ToString();
            }


        }


        static bool IsDeluxe(int input) {

            ////1st test, if number < 10 then exit now.
            //if (input < 10) {
            //    return false;
            //}else if (input % 2 != 0) {
            //    return false;
            //}
            //else {

                //var retval = false;
                //var test = input.ToString();

                //for (var i = 1; i < test.Length; i++)
                //{

                //    if (test.Substring(i,1) == test.Substring((i - 1),1))
                //    {
                //        retval = true;
                //    }
                //    else {
                //        return false;
                //    }


                //}

            if (((input % 3 == 0 && input.ToString().Contains("3")) ||
                (input % 5 == 0 && input.ToString().Contains("5"))) &&
                input % 2 == 0
                ) {
                return true;
            }
            else {
                return false;
            }






        }


        static bool IsFakeDeluxe(int input)
        {

            if (((input % 3 == 0 && input.ToString().Contains("3")) ||
                (input % 5 == 0 && input.ToString().Contains("5"))) &&
                input % 2 != 0
                )
            {
                return true;
            }
            else
            {
                return false;
            }




            //1st test, if number < 10 then exit now.
            //if (input > 10 && input % 2 != 0)

            //{

            //    var retval = false;
            //    var test = input.ToString();

            //    for (var i = 1; i < test.Length; i++)
            //    {

            //        if (test.Substring(i, 1) == test.Substring((i - 1), 1))
            //        {
            //            retval = true;
            //        }
            //        else
            //        {
            //            return false;
            //        }


            //    }


            //    return retval;

            //}
            //else {
            //    return false;
            //}

        }



    }
}
