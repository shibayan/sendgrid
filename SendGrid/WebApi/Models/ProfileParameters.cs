using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class SetProfileParameter : ParameterBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }

    public class SetPasswordProfileParameter : ParameterBase
    {
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }

    public class SetUsernameProfileParameter : ParameterBase
    {
        public string Username { get; set; }
    }

    public class SetEmailProfileParameter : ParameterBase
    {
        public string Email { get; set; }
    }
}
