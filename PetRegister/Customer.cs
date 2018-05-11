using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    public class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        private string phone;

        public Pet ThePet { get; set; }

        public Licence PetLicence { get; set; }

        public static int id = 2000;


        public Customer() { Balance = 0.0m; }

        public Customer(string theFirstName, string theLastName, string theEmail, string thephone, DateTime birthday, string theAddress)
        {
            FirstName = theFirstName;
            LastName = theLastName;
            Email = theEmail;
            Phone = thephone;
            DateOfBirth = birthday;
            Address = theAddress;
            Balance = 0.0m;
            CustId = id;
            id++;


            
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length < 10)
                {
                    //throw new FieldAccessException("Phone number must be 10 digits");
                    throw new PhoneNumberExecption("Min 10 digits");

                }
                else
                {
                    phone = value;
                }
            }  
        }

        public void AddPet(Pet thePet)
        {
            ThePet = thePet;

        }

        public override string ToString()
        {
            if (ThePet == null)
            {
                return CustId + " " + FirstName + " " + LastName + " " + Phone + " " + Email + " " + DateOfBirth.ToShortDateString();
            }
            else
            {
                return CustId + " " + FirstName + " " + LastName + " " + Phone + " " + Email + " " + DateOfBirth.ToShortDateString() + " Pet Name: " + ThePet.PetName + " Owes " + Balance.ToString("c");
            }
        }
    }
}
