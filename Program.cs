using System;
using System.Diagnostics;
using System.Globalization;

namespace StringsApp
{
    class Program
    {
        public static TextInfo CurrentTextInfo { get; set; }

        private static void StringConversion()
        {
            string testString = "this is the FBI";
            CurrentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            string result;

            result = testString.ToLower();
            Console.WriteLine(result);

            result = testString.ToUpper();
            Console.WriteLine(result);

            result = CurrentTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);


        }
        static void Main(string[] args)
        {
            //StringConversion();
            //StringAsArray();
            //InterpolationAndLiteral();
            //StringBuilding();
            WorkingWithArrays();
        }
        private static void StringAsArray()
        {
            string testString = "Timothy";
            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString);
            }
        }
        private static void InterpolationAndLiteral()
        {
            string testString = "Tim Corey";
            string result = $@"c:\Demo\{testString}\.text";

            Console.WriteLine(result);
        }
        private static void StringBuilding()
        {
            //string testString = "Text";
            //testString = "Tim";

            //testString += " is a cool guy";
            //Console.WriteLine(testString);

            Stopwatch regularStopWatch = new Stopwatch();
            regularStopWatch.Start();

            string test = " ";

            for (int i = 0; i < 1000000; i++)
            {
                test += i;
            }

            regularStopWatch.Stop();
            Console.WriteLine($"RegularStopWatch: {regularStopWatch.ElapsedMilliseconds} ms");
        }
        private static void WorkingWithArrays()
        {
            int[] ages = new int[] { 2, 4, 6, 8, 10 };
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(",", ages);
            Console.WriteLine(results);

            string testString = "John,Tim,Joy,Greaat";
            string[] resultsArray = testString.Split(',');
            Array.ForEach(resultsArray, x => Console.WriteLine(x));
        }
    }

}