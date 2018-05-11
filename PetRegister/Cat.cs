using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    class Cat : Pet
    {
        public bool Declawed { get; set; }
        public string FurType { get; set; }

        public Cat():base()
        {

        }

        public Cat(string theName, string theBreed, string theSex, bool theVac, Customer theOwner, string theFurType, bool isDeclawed) : base( theName, theBreed, theSex,  theVac, theOwner)
        {
            Declawed = isDeclawed;
            FurType = theFurType;
        }

        public override string ToString()
        {
            return "Cat " + base.ToString();
        }
    }
}
