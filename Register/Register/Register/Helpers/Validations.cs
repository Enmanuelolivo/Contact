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
         
            if (pass1 != pass2)
            {
                return true;
            }
            return false;
        }
      
    }
    }

