using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

{
    enum TransactionType {Buy, Sell}
    class Program
    {
        
        static void Main(string[] args)
        {


            Console.WriteLine("Current Value Calculation");
            Console.WriteLine("Please enter Buy or Sell:");
            TransactionType trcType;
            string userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            int sign;
            if (trcType==TransactionType.Buy)
            {
                sign = 1;
            }
            else
            {
                sign = -1;
            }

            Console.WriteLine("Please enter Nominal:");
            int nominal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Price:");
            int price = Convert.ToInt32(Console.ReadLine());


            int currentValue = price*nominal*sign;
            Console.WriteLine($"Calculated Current Value is: {currentValue}");

            Console.WriteLine("=====================");
           // Console.WriteLine("Profit/Loss Calculation");


            Console.ReadKey();


        }
    }
}
