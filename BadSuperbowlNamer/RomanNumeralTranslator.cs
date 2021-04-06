using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralTranslator
    {
        public string NumberToNumeral(int numberToConvert)
        {
            //throw new NotImplementedException(); // for when you just want to have a non-functioning method

            //var result = "";

            var result = numberToConvert switch // switch expression
            {
                1 => "I",
                5 => "V",
                9 => "IX"
            };

            //switch (numberToConvert)
            //{
            //    case 1: 
            //    result += "I";
            //        break;
            //    case 5:
            //        result += "V";
            //        break;
            //    case 9:
            //        result += "IX";
            //        break;
            //}
           
            return result;
        }
    }
}
