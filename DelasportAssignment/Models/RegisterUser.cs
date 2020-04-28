using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Models
{
    public class RegisterUser
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Prefix { get; set; }
        public string CellPhone { get; set; }
        public string DayOfBirth { get; set; }
        public string MonthOfBirth { get; set; }
        public string YearOfBirth { get; set; }
        public bool TermsAndConditions { get; set; }
        public bool NewsLetter { get; set; }
    }
}
