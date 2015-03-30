using System;

using SendGrid.Internal;

namespace SendGrid.WebApi.Models
{
    public class GetBlocksParameter : ParameterBase
    {
        public int? Days { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }

    public class DeleteBlocksParameter : ParameterBase
    {
        public string Email { get; set; }
    }

    public class CountBlocksParameter : ParameterBase
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Type { get; set; }
    }
}
