using System;
using System.Collections.Generic;
using System.Text;

namespace July27Examples
{
    //Abstract classes are a base class that defines a set of instructions for any inheriting class.
    //Any inheriting class must also have everything in an abstract class. 
    public abstract class Automobile
    {
        protected abstract string Model { get; set; }  
        
        public abstract string Make { get; set; }

        public abstract void Build();
    }
}
