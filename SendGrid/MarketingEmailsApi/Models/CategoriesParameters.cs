using SendGrid.Internal;

namespace SendGrid.MarketingEmailsApi.Models
{
    public class CreateCategoriesParameter : ParameterBase
    {
        public string Category { get; set; }
    }

    public class AddCategoriesParameter : ParameterBase
    {
        public string Category { get; set; }

        public string Name { get; set; }
    }

    public class RemoveCategoriesParameter : ParameterBase
    {
        public string Category { get; set; }

        public string Name { get; set; }
    }

    public class ListCategoriesParameter : ParameterBase
    {
        public string Category { get; set; }
    }
}
