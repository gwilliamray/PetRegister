using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    class Dog : Pet
    {
        public string Job { get; set; }
        public bool School { get; set; }

        public Dog() : base()
        {

        }

        public Dog(string theName, string theBreed, string theSex, bool theVac, Customer theOwner, string ajob, bool theSchool):base( theName, theBreed,  theSex,  theVac,  theOwner)
        {
            Job = ajob;
            School = theSchool;
        }

        public override string ToString()
        {
            return  "Dog " + base.ToString();
        }
    }
}
