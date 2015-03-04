using System;

using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class GetSpamReportsParameter : ParameterBase
    {
        public int? Days { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public string Email { get; set; }
    }

    public class DeleteSpamReportsParameter : ParameterBase
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Email { get; set; }

        public bool? DeleteAll { get; set; }
    }

    public class CountSpamReportsParameter : ParameterBase
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
