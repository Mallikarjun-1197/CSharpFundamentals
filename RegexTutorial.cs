using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
     
    // To use Regex we need to use System.Text.RegularExpressions NS,
    public static class RegexTutorial
    {
        public static bool IsValid(string pattern,string text)
        {
            // ^ : start of string
            //[ : beginning of character group
            //a - z : any lowercase letter
            //A - Z : any uppercase letter
            //0 - 9 : any digit
            //_ : underscore
            //] : end of character group
            //* : zero or more of the given characters
            //$ : end of string
            Regex obj = new Regex(pattern);
            return obj.IsMatch(text);
        }
        public static void RegexTut()
        {
            //bool val = RegexTutorial.IsValid("[a-g]{2}", "ag");  // any string having length 2 and its chrs in a - g
            // from above example if, we say abcz and validate aginst [a-g]{3} then we get answer as true.. 
            // to make our regex more rigid we need to use ^ and $ symbols.
            // so when we say our pattern is ^[a-g]{3}$ then we are hard stopping our inp for length of 3 only in above case 
            //this do not happen.

            // chars between a to g and length is 3 and min length is 1.
            //bool val = RegexTutorial.IsValid("^[a-g]{1,3}$", "x");

            //validate entered mobile number.
            // bool val = RegexTutorial.IsValid("^[0-9]{10}$","9503943900");


            //Numneric data with min len 3 and max len 7. -- > Validate input amount to transfer at one shot.
            //bool val = RegexTutorial.IsValid("^[0-9]{3,7}$", "12345a7");

            //validate invoice number it may be like first 3 characters are alphabets and next 5 are numnbners INV00001 of total 8 length
            //bool val = RegexTutorial.IsValid("^[a-zA-Z]{3}[0-9]{5}$", "INV00001");

            //validate a URL  www.random.domain
            //bool val = RegexTutorial.IsValid("^WWW.[a-zA-Z0-9]{5}.(com|org|in)$", "WWW.paint.com"); // www. any aplhanumericval of len 5 .com or .org or.in

            //Email validation mallikshastri2@gmail.com
            // here if i give [a-zA-Z0-9]@(gmail|yahoo|hotmail).(com) @2gmail.com will be considered but initial characters are not counted since we are 
            //not mentioning any length to check. in such cases we can use, ([a-zA-Z0-9+) to consider empty of n number of chrs
            bool val = RegexTutorial.IsValid("^([a-zA-Z0-9]+)@(gmail|yahoo|hotmail).(com)$", "mallikshastri2@gmail.com");

            Console.WriteLine(val.ToString()); // just to print on UI.
            Console.ReadLine();
        }
    }
}
