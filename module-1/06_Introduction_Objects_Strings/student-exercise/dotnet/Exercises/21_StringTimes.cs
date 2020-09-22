using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and a non-negative int n, return a larger string that is n copies of the original string.
         StringTimes("Hi", 2) → "HiHi"
         StringTimes("Hi", 3) → "HiHiHi"
         StringTimes("Hi", 1) → "Hi"
         */
        public string StringTimes(string str, int n)
        {   
            String result = "";
            for (int i = 0; i < n; i++)
            {
                result = result + str;
            }
            return result;

           /* AssertEquals("Input: FrontTimes(\"Abc\", 3)", "AbcAbcAbc", exercises.FrontTimes("Abc", 3));
            AssertEquals("Input: FrontTimes(\"Ab\", 4)", "AbAbAbAb", exercises.FrontTimes("Ab", 4));
            AssertEquals("Input: FrontTimes(\"A\", 4)", "AAAA", exercises.FrontTimes("A", 4));
            AssertEquals("Input: FrontTimes(\"\", 4)", "", exercises.FrontTimes("", 4));
            AssertEquals("Input: FrontTimes(\"Abc\", 0)", "", exercises.FrontTimes("Abc", 0));*/
        }
    }
    }

