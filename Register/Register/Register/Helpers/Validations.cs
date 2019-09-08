using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Register.Helpers
{
    public class Validations
    {
        public static bool NotEmpty(string d)
        {
            bool r = false;
            if (!string.IsNullOrEmpty(d))
            {
                r = true;
            }
            return r;

            }

         public static bool PassVerification(string pass1, string pass2)
        {
            bool r = false;
            if (string.IsNullOrEmpty(pass1) && !string.IsNullOrEmpty(pass2))
            {
                if (pass1.Equals(pass2))
                    r = true;
            }
            else
                r = false;
            return r;
        }
        public static bool ValidateEmail(string e)
        {
           
            var email =
                 @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
             + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
             + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
           
            if (Regex.IsMatch(e, email))
            {
                return true;
            }
           
            return false;
        }
    }
    }

