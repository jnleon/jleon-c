using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; } = "TRACTOR";

        public string MakeSoundOnce()
        {
            return "BRRRRRRRR";
        }

        public string MakeSoundTwice()
        {
            return "BRRRRRRRR BRRRRRRR";
        }
    }
}
