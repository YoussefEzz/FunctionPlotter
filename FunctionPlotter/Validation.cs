using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionPlotter
{

   /// <summary>
   /// static class to validate string, integer, double 
   /// </summary>
  public static class Validation
    {
        //validate string
        public static bool StringValidator(string input)
        {
            string pattern = @"[a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //validate integer
        public static bool IntegerValidator(string input)
        {
            string pattern = @"[0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //validate double
        public static bool DoubleValidator(string input)
        {
            string pattern = @"^(-?)(0|([1-9][0-9]*))(\.[0-9]+)?$";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
             
    }
}
