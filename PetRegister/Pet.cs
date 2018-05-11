using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    public abstract  class Pet
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public bool Vaccination { get; set; }
        public Customer PetOwner { get; set; }
        public bool IsFixed { get; set; }


        public static int nextId = 5000;
        public Pet() { }

        public Pet(string theName, string theBreed, string theSex, bool theVac, Customer theOwner)
        {
            PetName = theName;
            Breed = theBreed;
            Sex = theSex;
            Vaccination = theVac;
            PetOwner = theOwner;
            Id = nextId;
            nextId++;
            PetOwner.AddPet(this);
            PetOwner.PetLicence = new Licence(PetOwner, this);

        }

        public override string ToString()
        {
            return Id + " " + PetName + " " + Breed + " Has Vaccination " + Vaccination + " " + PetOwner.FirstName +" "+ PetOwner.LastName;

        }
    }
}
