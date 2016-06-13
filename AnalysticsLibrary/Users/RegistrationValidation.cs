using AnalysticsLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Users
{
    public static class RegistrationValidation
    {
        public static Registration ValidateRegistraion(this Registration register) {

            if (register.Username.Length <= 4)
                return null;

            if (register.Password.Length <= 6)
                return null;

            if (!register.Email.IsValidEmail())
                return null;

            return register;
        }
        
         
    }
}
