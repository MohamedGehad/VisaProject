namespace VisaProject.Models
{
    public class Armina
    {
        public int id { get; set; }
        public string marriageVoucher { get; set; }
        public string hrLetter { get; set; }
        public string birthCertificate { get; set; }

        public int ImageId { get; set; }

        public Image Image { get; set; }
    }

}
