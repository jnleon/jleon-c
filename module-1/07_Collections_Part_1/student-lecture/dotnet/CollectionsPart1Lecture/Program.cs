using System;
using System.Collections.Generic;
using System.Threading;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
		{				// LIST LIVES IN SYSTEM.COLLECTIONS.GENERIC
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");
			List<string> names = new List<string>();
			names.Add("Katie");
			names.Add("Jason");
			names.Add("Juan");

			List<string> students = new List<string>();
			students.AddRange(names);
			// "Zach", "Matt","Lisa"
								
			List<int> quizScores = new List<int>();



			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");
			for(int i=0; i<students.Count; i++)
            {
				Console.WriteLine(students[i]);

            }
			Console.WriteLine("use to join to print");
			Console.WriteLine(String.Join('|', students));

			students.Insert(2, "Chris");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			students.Add("Lisa");
			Console.WriteLine(String.Join (' ' ,students));


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			students.IndexOf("Lisa");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			foreach (string name in names)

				Console.WriteLine(name + " ");

		}
	}
}
