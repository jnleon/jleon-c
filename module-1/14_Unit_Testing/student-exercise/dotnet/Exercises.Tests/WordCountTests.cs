using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
 [TestClass()]
    public class WordCountTests
    {
   [TestMethod]
   public void GetCount()
        {
            string[] miaw = { "ba", "ba", "black", "sheep" };
            string[] miaw2 = { "a", "b", "a", "c", "b" };
            string[] miaw3 = { };
            string[] miaw4 = { "c", "b", "a" };


            Dictionary<string, int> NewDic7 = new Dictionary<string, int>();
            NewDic7.Add("ba", 2);
            NewDic7.Add("black", 1);
            NewDic7.Add("sheep", 1);

            WordCount lae = new WordCount();
            CollectionAssert.AreEqual(NewDic7, lae.GetCount(miaw));;


            Dictionary<string, int> NewDic8 = new Dictionary<string, int>();
            NewDic8.Add("a", 2);
            NewDic8.Add("b", 2);
            NewDic8.Add("c", 1);

            WordCount lae1 = new WordCount();
            CollectionAssert.AreEqual(NewDic8, lae1.GetCount(miaw2)); ;


            Dictionary<string, int> hello2 = new Dictionary<string, int>();
            WordCount lae2 = new WordCount();
            CollectionAssert.AreEqual(hello2, lae2.GetCount(miaw3)); ;


            Dictionary<string, int> NewDic9 = new Dictionary<string, int>();
            NewDic9.Add("c", 1);
            NewDic9.Add("b", 1);
            NewDic9.Add("a", 1);

            WordCount lae3 = new WordCount();
            CollectionAssert.AreEqual(NewDic9, lae3.GetCount(miaw4)); ;
        }
        [TestMethod]
        public void GetCountVariable()
        {
            string[] miaw = { "12345", "-12345", "12345", "12345" };
            string[] miaw2 = { "$", "M", "0", "n", "e", "Y" };
            string[] miaw4 = { "GRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR", "GRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR", "GRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR", "WOOOOOOF", "WOOOOOOF", "SSssSSSSSssssSssssS", "SSssSSSSSssssSssssS" };


            Dictionary<string, int> NewDic7 = new Dictionary<string, int>();
            NewDic7.Add("12345", 3);
            NewDic7.Add("-12345", 1);

            WordCount lae = new WordCount();
            CollectionAssert.AreEqual(NewDic7, lae.GetCount(miaw)); ;

            Dictionary<string, int> NewDic8 = new Dictionary<string, int>();
            NewDic8.Add("$", 1);
            NewDic8.Add("M", 1);
            NewDic8.Add("0", 1);
            NewDic8.Add("n", 1);
            NewDic8.Add("e", 1);
            NewDic8.Add("Y", 1);

            WordCount lae1 = new WordCount();
            CollectionAssert.AreEqual(NewDic8, lae1.GetCount(miaw2)); ;

            Dictionary<string, int> NewDic9 = new Dictionary<string, int>();
            NewDic9.Add("GRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR", 3);
            NewDic9.Add("WOOOOOOF", 2);
            NewDic9.Add("SSssSSSSSssssSssssS", 2);

            WordCount lae3 = new WordCount();
            CollectionAssert.AreEqual(NewDic9, lae3.GetCount(miaw4));
        }
    }
}
