using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

{
    enum TransactionType { Buy, Sell }
    class InvestmentCalculator
    {

        static void Main(string[] args)
        {
            //Current Value Calculation
            Console.WriteLine("Current Value Calculation");
            Console.WriteLine("Please enter Buy or Sell:");
            TransactionType trcType;
            string userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            Console.WriteLine("Please enter Nominal:");
            int nominal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            int sign = trcType == TransactionType.Buy ? 1 : -1;
            /*another way of calculating sign
            int sign;
            if (trcType == TransactionType.Buy)
            {
                sign = 1;
            }
            else
            {
                sign = -1;
            }*/

            double currentValue = price * nominal * sign;
            Console.WriteLine($"Calculated Current Value is: {currentValue}");
            Console.WriteLine("=======================");

            //Profit/Loss Calculation only for Sell transaction type
            if (trcType == TransactionType.Sell)
            {
                Console.WriteLine("Profit/Loss Calculation");
                Console.WriteLine("Please enter original Price:");
                double origPrice = Convert.ToDouble(Console.ReadLine());

                //int factor = trcType == TransactionType.Sell ? 1 : 0;
                double profitLoss = nominal * (price - origPrice);
                Console.WriteLine($"Calculated Profit/Loss is: {profitLoss}");
            }
            else
            {
                Console.WriteLine("No Profit/Loss calculation for Buy transaction");
            }
            Console.ReadKey();


        }
    }
}
