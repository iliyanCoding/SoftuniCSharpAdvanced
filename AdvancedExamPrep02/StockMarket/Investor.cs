using System.Collections.Generic;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio { get; set; } = new List<Stock>();

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public decimal MoneyToInvest { get; set; }

        public string BrokerName { get; set; }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
        }

        private int Count()
        {
            return Portfolio.Count;
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest > stock.PricePerShare)
            {
                Portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!Portfolio.Contains(Portfolio.Find(stock => stock.CompanyName == companyName)))
            {
                return $"{companyName}does not exist.";
            }
            else
            {
                if (Portfolio.Find(stock => stock.CompanyName == companyName).PricePerShare > sellPrice)
                {
                    return $"Cannot sell {companyName}.";
                }

                this.MoneyToInvest += sellPrice;
                return $"{companyName} was sold.";
            }
        }

        public Stock FindStock(string companyName)
        {
            if (Portfolio.Contains(Portfolio.Find(stock => stock.CompanyName == companyName)))
            {
                return Portfolio.Find(stock => stock.CompanyName == companyName);
            }
            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count == 0)
            {
                return null;
            }
            else
            {
                Stock biggestCompany = Portfolio[0];
                foreach (var stock in Portfolio)
                {
                    if (stock.MarketCapitalization > biggestCompany.MarketCapitalization)
                    {
                        biggestCompany = stock;
                    }
                }

                return biggestCompany;
            }
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");
            for (int i = 0; i < Portfolio.Count; i++)
            {
                sb.AppendLine(Portfolio[i].ToString());
            }
            return sb.ToString();
            //return $"The investor {this.FullName} with a broker {this.BrokerName} has stocks: {string.Join("\r\n", Portfolio)}";
        }

    }
}
