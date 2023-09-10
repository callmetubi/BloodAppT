using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodApp
{
    public class CheckEmail
    {
        public bool IsValidEmail(string eMail)
        {
            bool Result = false;
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));//Looking at the dot and @ signs in e-mail address writing
            }
            catch
            {
                Result = false;
            };

            return Result;
        }
    }
}
