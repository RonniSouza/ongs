using static System.Net.Mime.MediaTypeNames;

namespace Ongs.Domain.Entities
{
    public class Ong : Base
    {

        public Ong(string name, string email, string description, string image, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Description = description;
            this.image = image;
            this.Password = password;

        }
        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Description { get; private set; }

        public string image { get; private set; }

        public string Password { get; private set; }

        protected Ong() { }

        public Ong(string name, string email, string description, string password)
        {
            Name = name;
            Email = email;
            Description = description;
            Password = password;
        }

        public void ChangeName(string name)
        {
            Name = name;
            Validate();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }

        public void ChangeDescription(string description)
        {
            Description = description;
            Validate();
        }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}