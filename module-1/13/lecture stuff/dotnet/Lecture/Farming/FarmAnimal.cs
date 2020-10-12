using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : ISingable //all farm animals are Singable but not all farm animals are sellable so we put the interface on teh ones that are
    {       
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        private bool isSleeping = true;

        public void GoToSleep()
        {
            isSleeping = true;
        }
        public void Wakeup()
        {
            isSleeping = false;
        
        
        }
        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The noise made when the farm animal makes a sound.
        /// </summary>
        /// <returns></returns>
        public virtual string MakeSoundOnce()
        {
            if (isSleeping) return "zzzzzzzzz";
            else return MakeAwakeSoundOnce();
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public virtual string MakeSoundTwice()
         
        {
            if (isSleeping) return "zzzzzzzzz";
            else return MakeAwakeSoundTwice();
        }

        public virtual string MakeAwakeSoundOnce()
        {
            return "";
        }

        public virtual string MakeAwakeSoundTwice()
        {
            return "";
        }

        public string Eat()
        {
            return "mmmm";
        }
    }
}
