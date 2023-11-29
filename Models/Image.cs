namespace VisaProject.Models
{
    public class Image
    {
        public int id { get; set; }

        public string Passport { get; set; }

        public string Photograph { get; set; }
        public string NationalID { get; set; }

        public int userId { get; set; }
        public User user { get; set; }




    }
}
