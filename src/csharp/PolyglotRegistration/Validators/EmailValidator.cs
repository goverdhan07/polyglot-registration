using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace PolyglotRegistration.Validators
{
    public class EmailValidator : IValidator<string>
    {
        public bool IsValid(string inputValue)
        {
            string email = txtemail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                lbl_message.Text=email + " is Valid Email Address";  
            return true;
        }
    }
}
