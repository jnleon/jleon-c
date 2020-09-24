using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			Dictionary<string, bool> paidInFullbySSN = new Dictionary<string, bool>();
			paidInFullbySSN["111-11-1111"] = true;
			Console.WriteLine("Has paid?" + paidInFullbySSN["111-11-1111"]);

            paidInFullbySSN["222-22-2222"] = false;

			
			
			paidInFullbySSN["222-22-2222"] = true;
			paidInFullbySSN.Add("111-11-1111", true); //ERROR BECAUSE ALREADY EXISTS


			// look zipcode by name
			Dictionary<string, string> zipCodes = new Dictionary<string, string>();

			zipCodes["jacob"] = "45419";
			zipCodes["katie"] = "45419"; //duplicate values are fine:))








		}
	}
}
