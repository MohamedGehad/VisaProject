using System.ComponentModel.DataAnnotations.Schema;

namespace VisaProject.Models
{
    public class User
    {
        public int Id { get; set; } 
        public Guid Code { get; set; } = new Guid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string PassportNumber { get; set; }
        public DateTime ExpirePassportNumber { get; set; }

        public string Profession { get; set; }
        public string PurposeOfTravel { get; set; }

        public visaStatus Status { get; set; } = visaStatus.pending;

        public DateTime TravelDate { get; set; }

        //Do Three Relship 

        //[ForeignKey("CountryFrom")]
        public int CountryFromId { get; set; }
        public Country CountryFrom { get; set; }
        //[ForeignKey("CountryLiveIn")]
        public int CountryliveInId { get; set; }
        public Country CountryLiveIn { get; set; }

        public int CountryDayCostId { get; set; }
        public CountryDayCost CountryDayCost { get; set; }

    }
}
