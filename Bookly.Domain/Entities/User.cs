using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User() { 
        }

        public User(int id, string name, string email, string password, DateTime registrationDate) : base(id)
        { 
            Name=name;
            Email=email;
            Password=password;  
            RegistrationDate= registrationDate;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
