using PolyglotRegistration.Validators;
using Xunit;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PolyglotRegistration.Tests
{
    public class EmailValidatorTests
    {
        [Theory]
        [InlineData("person@example.com", true)]
        [InlineData("person@co", true)]
        [InlineData("name.lastname@example.com", true)]
        [InlineData("person2@test.org", true)]
        [InlineData("Person@Example.com", false)]
        [InlineData("person+3@example.com", false)]
        [InlineData("pe@rson@example.com", false)]
        [InlineData(".person@example.com", false)]
        [InlineData("person@example.com.", false)]
        [InlineData("person@", false)]
        public void ShouldValidateEmail(string email, bool isValid)
        {
            string email = txtemail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                lbl_message.Text=email + " is Valid Email Address";  
            else
                lbl_message.Text = email + " is Invalid Email Address";
        }
 
        protected void Validate_Click(object sender, EventArgs e)
        {
            ShouldValidateEmail();
        }
            
    }
}
