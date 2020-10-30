using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pincode
{
    class Pattern
    {
        //pattern for pincode comprising of only digits
        //which also allows spaces
        public static string REGEX_PINCODE = "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$";//400088 //400 088

        /// <summary>
        /// Validates the pincode.
        /// </summary>
        /// <param name="pincode">The pincode.</param>
        /// <returns></returns>
        public bool validatePincode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}

