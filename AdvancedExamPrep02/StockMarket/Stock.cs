namespace StockMarket
{
    public class Stock
    {


        public string CompanyName { get; set; }

        public string Director { get; set; }

        public decimal PricePerShare { get; set; }

        public int TotalNumberOfShares { get; set; }

        public decimal MarketCapitalization { get; set; }

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;
            this.MarketCapitalization = pricePerShare * totalNumberOfShares;
        }

        public override string ToString()
        {
            return $"Company: {this.CompanyName}\r\nDirector: {this.Director}\r\nPrice per share: ${this.PricePerShare}\r\nMarket capitalization: ${this.MarketCapitalization}";

        }
    }
}
