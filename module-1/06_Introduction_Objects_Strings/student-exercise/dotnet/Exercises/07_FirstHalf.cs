﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
         FirstHalf("WooHoo") → "Woo"
         FirstHalf("HelloThere") → "Hello"
         FirstHalf("abcdef") → "abc"
         */
        public string FirstHalf(string str)
        {
            string half = str.Substring(0, str.Length / 2);
            if (str.Length % 2 == 0)
                return half;
            return str;
        }
    }
}
