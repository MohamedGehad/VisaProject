namespace VisaProject.Models
{
    public class CountryDayCost
    {
        public int id { get; set; }
        public int cost { get; set; }


        public int CountryId { get; set; }
        public int DayId { get; set; }
        public Country Country { get; set; }
        public Day Day { get; set; }
    }
}
