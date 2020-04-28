using Bogus;
using DelasportAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DelasportAssignment.Hooks
{
    [Binding]
    public sealed class HooksUser
    {
        
        private readonly DataContex dataContex;
        private readonly Faker faker;

        public HooksUser( DataContex dataContex)
        {
            this.dataContex = dataContex;
            this.faker = new Faker("en");
        }

        [BeforeScenario("CreateUser", Order = 0)]
        public void CreateTestingData()
        {
            var defutUser = new RegisterUser();
            defutUser.FirstName = this.faker.Name.FirstName();
            defutUser.LastName = this.faker.Name.LastName();
            defutUser.Country = this.faker.Address.Country();
            defutUser.Currency = this.faker.Finance.Currency(true).ToString();
            defutUser.CellPhone = this.faker.Phone.PhoneNumber();
            defutUser.Email = this.faker.Internet.Email();
            defutUser.Username = this.faker.Internet.UserName();
            defutUser.Password = this.faker.Internet.Password();

            var dateOfBirth = this.faker.Date.Past(20, DateTime.Parse("2010-01-01"));
            defutUser.DayOfBirth = dateOfBirth.Day.ToString();
            defutUser.MonthOfBirth = dateOfBirth.Month.ToString("MMMM");
            defutUser.YearOfBirth = dateOfBirth.Year.ToString();

            this.dataContex.RegisterUser = defutUser;
        }
    }
}
