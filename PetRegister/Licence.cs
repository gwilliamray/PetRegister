using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    public class Licence
    {
        public Customer PetOwner { get; set; }
        public Pet OwnerPet { get; set; }
        public int Id { get; set; }    // This Id will be the licence number
        public decimal Fee { get; set; }

        public static int licenceNumber = 65000;


        public Licence(Customer theCustomer, Pet thePet)
        {
            PetOwner = theCustomer;
            OwnerPet = thePet;
            Id = licenceNumber;
            licenceNumber++;
            Fee = 0.0m;
            // Calculate the Fee
            //Console.WriteLine("Age " + CalculateAge(PetOwner.DateOfBirth));
            CalculateFee();
            PetOwner.Balance = Fee;
        }

        private void CalculateFee()
        {
            int age = CalculateAge(PetOwner.DateOfBirth);
            if(age < 62)
            {
                // if it is a Dog
                if(OwnerPet.GetType() == typeof(Dog))
                {
                    if (OwnerPet.IsFixed)
                    {
                        Fee = 21.0m;
                    }
                    else
                    {
                        Fee = 52.0m;
                    }
                }
                else
                {
                    if (OwnerPet.IsFixed)
                    {
                        Fee = 21.0m;
                    }
                    else
                    {
                        Fee = 38.0m;
                    }
                }
            }
            else // > 62
            {
                if (OwnerPet.GetType() == typeof(Dog))
                {
                    if (OwnerPet.IsFixed)
                    {
                        Fee = 18.0m;
                    }
                    else
                    {
                        Fee = 32.0m;
                    }
                }
                else 
                {
                    if (OwnerPet.IsFixed)
                    {
                        Fee = 18.0m;
                    }
                    else
                    {
                        Fee = 32.0m;
                    }
                }
            }
        }

        private  int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear <= dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
