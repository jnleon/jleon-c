using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    public interface ISingable
    {
         
        string Name { get;  }            
        string MakeSoundOnce();
        string MakeSoundTwice();

    }
}
