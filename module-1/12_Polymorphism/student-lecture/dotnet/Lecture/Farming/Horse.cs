using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal, ISellable
    {
        public decimal Price { get; } = 50M;


        
        public Horse() : base("HORSE")
        {
        }

        /// <summary>
        /// The single noise the horse makes.
        /// </summary>
        /// <returns></returns>
        public override string MakeSoundOnce()
        {
            return "NEIGH";
        }

        /// <summary>
        /// The double noise the horse makes.
        /// </summary>
        /// <returns></returns>
        public override string MakeSoundTwice()
        {
            return "NEIGH NEIGH";
        }
    }
}
