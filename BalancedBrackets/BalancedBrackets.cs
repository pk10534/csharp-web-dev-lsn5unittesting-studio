using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */



        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[' && str.IndexOf('[') < str.IndexOf(']') && str.Contains(']'))
                {
                    brackets++;
                }
                else if (ch == ']') // && str.IndexOf(']') > str.IndexOf('['))
                {
                    brackets--;
                }
                else if ((!str.Contains('[')) && (!str.Contains(']')))
                {
                    return false;
                }

            }
            return brackets == 0;
        }

        /* FORMAT OF ORIGINAL CODE BELOW
         * 
         * 
        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[' && str.IndexOf('[') < str.IndexOf(']'))
                {
                    brackets++;
                }
                else if (ch == ']') // && str.IndexOf(']') > str.IndexOf('['))
                {
                    brackets--;
                }

            }
            return brackets == 0;
        }
        











        public static void ()
        {
            string searchString = "\u00ADm";
            string s1 = "ani\u00ADmal";
            string s2 = "animal";

            Console.WriteLine(s1.IndexOf(searchString, 2, 4));
            Console.WriteLine(s2.IndexOf(searchString, 2, 4));

        }
        */
















    }
}
