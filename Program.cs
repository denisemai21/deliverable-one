using System;
using System.Globalization;
namespace deliverable_one
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a, b, c, average, total;

            a = 621.32;
            b = 524.22;
            c = 322.32;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            total = a + b + c; //This is the equation I used to total my variables
            Console.WriteLine("Total:" + total);
            average = (a + b + c) / 3; //This is the equation I used to average my variables
            Console.WriteLine("Average:" + average); //This will output the average results of the variables.

            double minimumValue = Math.Min(Math.Min(a, b), c);
            double maxiumValue = Math.Max(Math.Max(a, b), c);

            Console.WriteLine("Lowest Number:" + minimumValue);
            Console.WriteLine("Highest Numer:" + maxiumValue);

            Console.WriteLine(string.Format("US:" + "{0:c}", total));
            Console.WriteLine(string.Format(new CultureInfo("sv-SE"), "Swedish:" + "{0:C}", total));
            Console.WriteLine(string.Format(new CultureInfo("ja-JP"), "Japanese:" + "{0:C}", total));
            Console.WriteLine(string.Format(new CultureInfo("th-TH"), "Thai:" + "{0:C}", total));

            Console.ReadLine();
            
            
        }
    }
}