using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pincode
{
    class Pattern
    {
        //pattern for pincode 
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";//400088

        /// <summary>
        /// Validates the pincode.
        /// </summary>
        /// <param name="pincode">The pincode.</param>
        public bool validatePincode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}