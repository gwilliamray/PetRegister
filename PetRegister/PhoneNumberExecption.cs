using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    class PhoneNumberExecption : Exception
    {
        public PhoneNumberExecption() : base("Phone number problems")
        {
           

        }

        public PhoneNumberExecption(string aMessage) : base(aMessage)
        {

        }
    }
}
