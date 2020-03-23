using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace TravelProcessor
{
    static class Program
    {
        private static async Task Main(string[] args)
        {
            Log("Starting up expense approver2...");
            var configuration = GetConfiguration(args);

            string connectionString = configuration["serviceBusConnectionString"];
            var queueClient = new QueueClient(connectionString);

            while (true)
            {
                Log("Pulling expense from the queue... ");
                var expense = await queueClient.DequeueExpenseAsync();
                if (expense != null)
                {
                    await ApproveExpenseAsync(expense);
                }
                await Task.Delay(TimeSpan.FromSeconds(10));
            }
        }

        private static void Log(string message)
        {
            Console.WriteLine($"[{DateTimeOffset.UtcNow.ToString("s")}Z] [{Environment.MachineName}] {message}");
        }

        private static IConfigurationRoot GetConfiguration(string[] args)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(typeof(Program).Assembly.Location))
                .AddJsonFile("appsettings.json")
                .Build();
        }

        private static async Task ApproveExpenseAsync(Expense expense)
        {
            Log($"Approving expense {expense.Description}, {expense.Amount} EUR");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Log("Approved");
        }
    }
}
