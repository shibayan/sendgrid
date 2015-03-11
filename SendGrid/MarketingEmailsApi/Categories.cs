using System.Threading.Tasks;

using SendGrid.Internal;
using SendGrid.MarketingEmailsApi.Models;

namespace SendGrid.MarketingEmailsApi
{
    public class Categories : MarketingEmailsApiBase
    {
        internal Categories(SendGridAccount account)
            : base(account, "categories")
        {
        }

        public Task CreateAsync(CreateCategoriesParameter parameter)
        {
            return PostAsync("create", parameter);
        }

        public Task AddAsync(AddCategoriesParameter parameter)
        {
            return PostAsync("add", parameter);
        }

        public Task RemoveAsync(RemoveCategoriesParameter parameter)
        {
            return PostAsync("remove", parameter);
        }

        public Task ListAsync(ListCategoriesParameter parameter)
        {
            return PostAsync("list", parameter);
        }
    }
}
