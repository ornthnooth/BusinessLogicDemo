namespace BusinessLogicDemo.Models
{
    public enum TransactionType
    {
        Send, Receive
    }
    public class Transactions
    {
        public required string TransactionID { get; set; }
        public double Count { get; set; }
        public TransactionType TransactionType { get; set;}
        public DateTime RequestDate { get; set; }
        public DateTime ExecuteDate { get; set; }

        //singular product Keep transactions Atomic
        public required Product Product { get; set; }

    }
}
