using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character. ");

            Console.WriteLine(name.Substring(0, 1));
            Console.WriteLine(name[name.Length - 1]);

            // 2. How do we write code that prints out the first three characters
            // Output: Ada


            Console.WriteLine("First 3 characters: {0}{1}{2} ", name[0], name[1], name[2]);
            Console.WriteLine("First 3 characters:" + name.Substring(0, 3));
            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("First 3 characters:" + name.Substring(0,3));
            Console.WriteLine("Last 3 characters: " + name.Substring(name.Length-3));


            // 4. What about the last word?
            // Output: Lovelace
            string[] words = name.Split(' ');
             Console.WriteLine("Last Word: {0}" + words[words.Length - 1]) ;
           
            Console.WriteLine("Last Word:" + name.Substring(4));

            int lastSpace = name.LastIndexOf(' ');
            Console.WriteLine("Last word" + name.Substring(lastSpace));

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\" " + name.Contains("Love"));



            // 6. Where does the string "lace" show up in name?
            // Output: 8

            Console.WriteLine("Index of \"lace\": " + name.IndexOf("lace"));

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            { 
                if (name[i] == 'a' || name[i] == 'A')
                    count++;
            }

            int countUsingIndex = 0;
            char [] searchFor = {'a' , 'A'};
            int index = name.IndexOfAny(searchFor);

            string rest = name;
            while(index != -1)
            {
                countUsingIndex++;
                 rest = rest.Substring(index + 1);
                index = rest.IndexOfAny(searchFor);
            }


            Console.WriteLine("Number of \"a's\": " + count+ " using index: " + countUsingIndex);


            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            name = name.Replace("Ada", "Ada, Countess Of Lovelace");
            
            Console.WriteLine(name);

            // 9. Set name equal to null.

            name = null;
            // 10. If name is equal to null or "", print out "All Done".

            if (name == null || name == "")
            {
                Console.WriteLine("All Done");

            }
        }
    }
}