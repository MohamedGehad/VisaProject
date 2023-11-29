namespace VisaProject.Models
{
    public class User
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string phone { get; set; }

            public string passportNumber { get; set; }
            public DateTime expirePassportNumber { get; set; }

            public string profession { get; set; }
            public string purposeOfTravel { get; set; }

            public bool status { get; set; }

            public DateTime travelDate { get; set; }

        //Do Three Relship 

        public int CountryFromId { get; set; }
        public int CountryliveInId { get; set; }
        public Country CountryFrom { get; set; }
        public Country CountryLiveIn { get; set; }

        public int countryDayCostId { get; set; }
        public CountryDayCost countryDayCost { get; set; }

    }
}
