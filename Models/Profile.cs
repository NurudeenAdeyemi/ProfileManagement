namespace ProfileManagement.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public DateTime DateofBirth { get; set; }

        //Mocking List of Profiles

        public static List<Profile> Profiles = new List<Profile> 
        { 
            new() { Id = 1, Name = "Aliya", Email = "aliya@gmail.com", PhoneNumber = "123445666", DateofBirth = new DateTime(2023, 10, 30, 2, 10, 28, 488, DateTimeKind.Utc) },

            new() { Id = 1, Name = "Ester", Email = "esther@gmail.com", PhoneNumber = "70947474784", DateofBirth = new DateTime(1993, 10, 30, 2, 10, 28, 488, DateTimeKind.Utc) },
            new() { Id = 1, Name = "Tope", Email = "tope@gmail.com", PhoneNumber = "07031905878", DateofBirth = new DateTime(1853, 10, 30, 2, 10, 28, 488, DateTimeKind.Utc) }
        };
    }
}
