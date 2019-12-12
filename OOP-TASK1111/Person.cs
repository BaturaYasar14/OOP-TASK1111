using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace OOP_TASK1111
{
    class Person
    {
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }
        public string IntroduceYourself()
        {
            return ("My name is: " + FirstName + ' ' + FamilyName + '\n'+ Address.PostalFormat);
        }
        public void SetData(string newFirstName, string newFamilyName, string newStreetName, string newHouseNumber, string newApartmentNumber, string newPostCode, string newCity, string newCountry)
        {
            this.FirstName = newFirstName; 
            this.FamilyName = newFamilyName;

            Address = new PostalAddress();
            Address.SetData( newStreetName,newHouseNumber,newApartmentNumber,newPostCode, newCity, newCountry);
        }
        public PostalAddress Address { get; private set; }
        public static ConsoleKeyInfo ReadKey { get; set; }
    }
}

