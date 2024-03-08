namespace ProfileManagement.Models.ViewModels
{
    public class ProfileInfoViewModel
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public DateTime DateofBirth { get; set; }
    }
}
