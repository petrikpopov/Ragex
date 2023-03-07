using System;
using System.Text.RegularExpressions;

namespace _07._03._2023HM
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            ////////////////////////////////
            string S = "ahb acb aeb aeeb adcb axeb";
            string Pattern = @"[a].[b]";
            MatchCollection match = Regex.Matches(S, Pattern);// совпадения
            Console.WriteLine(S);
            foreach (var i in match)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            ////////////////////////////////
            string S1 = "aba aca aea abba adca abea";
            string Pattern1 = @"[a]\w{2}[b]";
            MatchCollection match1 = Regex.Matches(S1, Pattern1);
            Console.WriteLine(S1);
            foreach (var i in match1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            ////////////////////////////////
            string S2 = "aa aba abba abbba abca abea";
            string Pattern3 = @"^(a)(b+)(a)";
            MatchCollection match2 = Regex.Matches(S2, Pattern3);
            Console.WriteLine(S2);
            foreach (var i in match2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            ////////////////////////////////
            string S3 = "aa aba abba abbba abca abea";
            string Pattern4 = @"^[(a)][(b*)][(a)]";
            MatchCollection match3 = Regex.Matches(S3, Pattern4);
            Console.WriteLine(S3);
            foreach (var i in match3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            ////////////////////////////////
            string S4 = "aa aba abba abbba abca abea";
            string Pattern_4 = @"^[(a)][(b?)][(a)]";
            MatchCollection match4 = Regex.Matches(S4, Pattern_4);
            Console.WriteLine(S4);
            foreach (var i in match4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            ////////////////////////////////
            string S5 = "ab abab abab abababab abea";
            string Pattern_5 = @"^[(ab)]{4}";
            MatchCollection match5 = Regex.Matches(S5, Pattern_5);
            Console.WriteLine(S5);
            foreach (var i in match5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy END!!!");
        }
    }
}
