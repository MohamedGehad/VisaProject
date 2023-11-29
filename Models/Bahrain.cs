using System.Reflection.PortableExecutable;

namespace VisaProject.Models
{
    public class Bahrain
    {
        public int id { get; set; }
        public string BankStatement { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
