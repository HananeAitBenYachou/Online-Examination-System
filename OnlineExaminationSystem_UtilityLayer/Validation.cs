﻿using System.Text.RegularExpressions;

namespace OnlineExaminationSystem_UtilityLayer
{
    public static class Validation
    {
        private static bool IsMatch(string pattern, string value)
        {
            return Regex.IsMatch(value, pattern);
        }

        public static bool ValidateFloat(string number)
        {
            string pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            return IsMatch(pattern, number);
        }

        public static bool ValidateInteger(string number)
        {
            string pattern = @"^[0-9]*$";

            return IsMatch(pattern, number);
        }

        public static bool IsValidNumber(string number)
        {
            return ValidateInteger(number) || ValidateFloat(number);
        }

        public static bool IsValidEmailAddress(string email)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            return IsMatch(pattern, email);
        }
    }
}
