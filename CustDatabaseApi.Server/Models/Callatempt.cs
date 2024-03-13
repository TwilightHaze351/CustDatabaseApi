namespace CustDatabaseApi.Server.Models
{
    public class CallAttempt
    {
        public int CallAttemptId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CallTime { get; set; }
        public virtual string Notes { get; set; } = string.Empty;

        // Navigation property to associate the call attempt with a customer
        public required Customer Customer { get; set; }
    }
}