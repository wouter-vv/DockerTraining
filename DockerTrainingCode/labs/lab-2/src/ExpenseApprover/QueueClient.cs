using System.Threading.Tasks;

namespace TravelProcessor
{
    public class QueueClient
    {
        public QueueClient(string connectionString)
        {

        }

        public Task<Expense> DequeueExpenseAsync()
        {
            return Task.FromResult(new Expense("Train", 5));
        }
    }
}
