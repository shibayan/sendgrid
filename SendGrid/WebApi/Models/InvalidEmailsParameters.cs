using System;

using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class GetInvalidEmailsParameter : ParameterBase
    {
        public int? Days { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public string Email { get; set; }
    }

    public class DeleteInvalidEmailsParameter : ParameterBase
    {
        public string Email { get; set; }
    }

    public class CountInvalidEmailsParameter : ParameterBase
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
