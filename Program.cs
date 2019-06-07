using System;
using System.Globalization;
namespace deliverable_one
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double average, total;

            Console.WriteLine("Please enter three numbers:");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Total:" + (num1 + num2 + num3));

            total = num1 + num2 + num3;
            average = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average:" + average);

            double minimumValue = Math.Min(Math.Min(num1, num2), num3);
            double maxiumValue = Math.Max(Math.Max(num1, num2), num3);

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