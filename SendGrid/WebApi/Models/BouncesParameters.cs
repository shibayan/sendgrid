using System;

using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class GetBouncesParameter : ParameterBase
    {
        public int? Days { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public int? Type { get; set; }

        public string Email { get; set; }
    }

    public class DeleteBouncesParameter : ParameterBase
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Type { get; set; }

        public string Email { get; set; }

        public bool? DeleteAll { get; set; }
    }

    public class CountBouncesParameter : ParameterBase
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Type { get; set; }
    }
}
