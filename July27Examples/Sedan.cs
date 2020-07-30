using System;
using System.Collections.Generic;
using System.Text;

namespace July27Examples
{
    public class Sedan : Automobile
    {
        public Sedan(string make, string model, int tires)
        {
            Make = Make;
            Model = Model;
            Tires = Tires;
        }


        //override -> you intend to override the behavior/contract set by the base class
        public override string Make { get; set; }
        protected override string Model { get; set; }
        public int Tires { get; set; }

        public override void Build()
        {
            Console.WriteLine($"I have build a sedan: {Make} {Model} with {Tires} tires");
        }

        //encapsulated within the Sedan class and exposes the value within the Build method
        private int CreateTires()
        {
            return Tires + 1;
        }

        
    }
}
