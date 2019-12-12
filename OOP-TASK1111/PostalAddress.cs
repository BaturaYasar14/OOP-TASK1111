using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK1111
{
    class PostalAddress
    {
        public string StreetName { get; private set; }
        public string HouseNumber { get; private set; }
        public string ApartmentNumber { get; private set; }
        public string PostCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }

        public string PostalFormat
        {
            get
            {
                return HouseNumber + '/' +  
                    ApartmentNumber + " " +
                    StreetName + "\n" +
                    City + "\n" +
                    PostCode + "\n" +
                    Country;
            }
        }
        public void SetData(string newStreetName, string newHouseNumber, string newApartmentNumber, string newPostCode, string newCity, string newCountry)
        {
            this.StreetName = newStreetName;
            this.HouseNumber = newHouseNumber;
            this.ApartmentNumber = newApartmentNumber;
            this.PostCode = newPostCode;
            this.City = newCity;
            this.Country = newCountry;

        }

    }
}


