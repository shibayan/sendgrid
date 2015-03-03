using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace SendGrid.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BlocksTest().Wait();

            Console.WriteLine("=================");

            BouncesTest().Wait();

            Console.WriteLine("=================");

            InvalidEmailsTest().Wait();

            Console.WriteLine("=================");

            SpamReportsTest().Wait();

            Console.WriteLine("=================");

            UnsubscribesTest().Wait();

            Console.ReadKey();
        }

        private static async Task BlocksTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.Blocks.GetAsync(new
            {
                days = 1
            });

            foreach (var item in result.Take(5))
            {
                Console.WriteLine(item.Reason);
            }
        }

        private static async Task BouncesTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.Bounces.GetAsync(new
            {
                days = 1
            });

            foreach (var item in result.Take(5))
            {
                Console.WriteLine(item.Reason);
            }
        }

        private static async Task InvalidEmailsTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.InvalidEmails.GetAsync(new
            {
                days = 10
            });

            foreach (var item in result.Take(5))
            {
                Console.WriteLine(item.Reason);
            }
        }

        private static async Task SpamReportsTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.SpamReports.GetAsync(new
            {
                days = 10
            });

            foreach (var item in result.Take(5))
            {
                Console.WriteLine(item.Email);
            }
        }

        private static async Task UnsubscribesTest()
        {
            var account = SendGridAccount.Parse(ConfigurationManager.ConnectionStrings["SendGrid"].ConnectionString);

            var result = await account.Unsubscribes.GetAsync(new
            {
                days = 10
            });

            await Task.WhenAll(result.Take(5).Select(x => account.Unsubscribes.DeleteAsync(x.Email)));

            await account.Unsubscribes.AddAsync("hoge@example.com");
        }
    }
}
