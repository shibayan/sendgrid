using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class GetCredentialsParameter : ParameterBase
    {
        public string Username { get; set; }
    }

    public class AddCredentialsParameter : ParameterBase
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class EditCredentialsParameter : ParameterBase
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class DeleteCredentialsParameter : ParameterBase
    {
        public string Username { get; set; }
    }
}
