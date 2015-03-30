using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class EditTimezoneParameter : ParameterBase
    {
        public string Timezone { get; set; }
    }

    public class ListTimezoneParameter : ParameterBase
    {
        public string Timezone { get; set; }
    }
}
