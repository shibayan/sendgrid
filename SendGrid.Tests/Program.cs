using System;
using System.Configuration;
using System.Threading.Tasks;

namespace SendGrid.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BlocksTest().Wait();

            BouncesTest().Wait();

            Console.ReadKey();
        }

        private static async Task BlocksTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.Blocks.GetAsync(new
            {
                days = 5
            });

            Console.WriteLine(result);
        }

        private static async Task BouncesTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.Bounces.GetAsync(new
            {
                days = 5
            });

            Console.WriteLine(result);
        }
    }
}
