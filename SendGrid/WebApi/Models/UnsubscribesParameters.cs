using System;

using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class GetUnsubscribesParameter : ParameterBase
    {
        public int? Days { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public string Email { get; set; }
    }

    public class DeleteUnsubscribesParameter : ParameterBase
    {
        public string Email { get; set; }
    }

    public class AddUnsubscribesParameter : ParameterBase
    {
        public string Email { get; set; }
    }
}
