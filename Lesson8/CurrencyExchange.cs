using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class CurrencyExchange
    {
        const decimal dollar = 385.5m;
        const decimal euro = 405;
        const decimal rubli = 4.9m;
        public string Exchange(decimal val, string currency)
        {
            string result = "";
            decimal exchange = 0;
            if(currency == "dollar")
            {
                exchange = dollar * val;
            }
            string stringResult = exchange.ToString();
            int intBeforResult = int.Parse(stringResult.Split('.')[0]);
            int intAfterResult = int.Parse(stringResult.Split('.')[1]);

            if(intBeforResult / 1000 != 0)
            {
                result += intBeforResult / 1000 + " hat " + 1000;
            }





            return result;
        }
    }
}
