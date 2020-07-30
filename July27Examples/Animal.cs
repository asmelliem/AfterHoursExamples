using System;
using System.Collections.Generic;
using System.Text;

namespace July27Examples
{
    public class Animal
    {
        private string _color;

        /*Behind the scene of how the getter and setter is working
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        */

        //5 properties or attributes of the object (Animal)
        public string Color { get; set; }

        public string Type { get; set; }    

        public string Name { get; set; }

        public int Size { get; set; }

        //can only be accessed by class Animal or any derived class of Animal
        protected int Age { get; set; }
        

        //Constructor - usually named the same thing as the class
        /*public Animal(string color, string type, string name, int size)
        {
            Color = color;
            Type = type;
            Name = name;
            Size = size;
        }
        */
    }
}
