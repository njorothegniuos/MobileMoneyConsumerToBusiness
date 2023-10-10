namespace Application.EventBus.Models
{
    public class ConsumerToBusinessReceivedEvent
    {
        public string TransactionType { get; set; } = string.Empty;
        public string TransID { get; set; } = string.Empty;
        public string TransTime { get; set; } = string.Empty;
        public string TransAmount { get; set; } = string.Empty;
        public string BusinessShortCode { get; set; } = string.Empty;
        public string BillRefNumber { get; set; } = string.Empty;
        public string InvoiceNumber { get; set; } = string.Empty;
        public string OrgAccountBalance { get; set; } = string.Empty;
        public string ThirdPartyTransID { get; set; } = string.Empty;
        public string MSISDN { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
