namespace VisaProject.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string Passport { get; set; }

        public string Photograph { get; set; }
        public string NationalID { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }  




    }
}
