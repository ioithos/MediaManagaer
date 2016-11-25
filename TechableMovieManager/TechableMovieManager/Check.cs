using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediaManager
{
    abstract class Check
    {

        public static bool isValidInput(string input)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\.\!\?\:\;\,\'\-\@_ ]+$");
            
            return regex.IsMatch(input);
        }

        public static bool isEmail(string input)
        {
            Regex phoneRegex = new Regex(@"^[a-zA-Z0-9\.\!\?\:\;\,\'\-_]+\@[a-zA-Z0-9\.\!\?\:\;\,\'\-_]+\.[a-zA-Z0-9\.\!\?\:\;\,\'\-_]+$");
            return phoneRegex.IsMatch(input);
        } 
        public static bool areValidInputs(params string[] inputs)
        {
            bool valid= true;

            foreach (string input in inputs)
            {
                if (!isValidInput(input))
                {
                    valid = false;
                    break;
                }
            }

            return valid;
        }
        public static bool isYear(string input)
        {
            bool result = true;
            Regex phoneRegex = new Regex(@"^\d{4}$");
            string current = "2016";
            string oldest = "1900";
            result = phoneRegex.IsMatch(input) 
                && current.CompareTo(input) >= 0 
                && oldest.CompareTo(input) <= 0;
            return  result;
        } 
        public static bool isPhone(string input)
        {
            Regex phoneRegex = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            return phoneRegex.IsMatch(input);
        }

        public static bool isUPC(string input)
        {
            Regex phoneRegex = new Regex(@"^\d{5,20}$");
            return phoneRegex.IsMatch(input);
        }

        

        public static bool isNumeric(params string[] inputs)
        {
            Regex numRegex = new Regex(@"^\d+$");
            bool isNum = true;

            foreach (string input in inputs)
            {
                if (!isNumeric(input) || !numRegex.IsMatch(input))
                {
                    isNum = false;
                    break;
                }
            }

            return isNum ;
        }

        public static bool isNumeric(string input)
        {
            int parsed;
            return (Int32.TryParse(input, out parsed));
        }

    }
}
