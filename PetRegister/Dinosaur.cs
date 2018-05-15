using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    class Dinosaur : Pet
    {
        //Needs lots of work
		public string DinoType {get; set;}
        public int NumberToes { get; set; }
        public bool HasFur { get; set; }

        public override string ToString()
        {
            return DinoType;
        }

    }
}
