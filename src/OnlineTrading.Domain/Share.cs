namespace OnlineTrading.Domain
{
    public class Share
    {
        public string Ticker {get;set;}
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}