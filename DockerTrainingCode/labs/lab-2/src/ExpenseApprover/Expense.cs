namespace TravelProcessor
{
    public class Expense
    {
        public string Description { get;}
        public decimal Amount { get;}

        public Expense(string description, decimal amountInEuros)
        {
            Description = description;
            Amount = amountInEuros;
        }
    }
}
