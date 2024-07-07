using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionApp
{
    public class CurrencyExchange
    {
        public string leftExchange { get; set; }
        public string rightExchange { get; set; }
        public double leftExchangeValue { get; set; }
        public double rightExchangeValue { get; set; }

        public CurrencyExchange(string leftExchange, string rightExchange, double leftExchangeValue, double rightExchangeValue)
        {
            this.leftExchange = leftExchange;
            this.rightExchange = rightExchange;
            this.leftExchangeValue = leftExchangeValue;
            this.rightExchangeValue = rightExchangeValue;
        }

        public override string ToString()
        {
            return String.Format("1{0} to {1} - {2:F2}", leftExchange, rightExchange, (1 / leftExchangeValue) * rightExchangeValue);
        }
    }
}
