using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Snake : FarmAnimal
    {

        public Snake() : base("SNAKE")
        { }
             public override string MakeSoundOnce()
        {
            return "SSSSSSSSSS";
        }

        /// <summary>
        /// The double noise the horse makes.
        /// </summary>
        /// <returns></returns>
        public override string MakeSoundTwice()
        {
            return "SSSSSSSSSSSSSSSSSSSS";
        }
    }



}





    
