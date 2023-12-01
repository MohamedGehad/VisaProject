namespace VisaProject.Models
{
    public class UserValidation
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ValidationId { get; set; }
        public validation Validation { get; set; }

    }
}
