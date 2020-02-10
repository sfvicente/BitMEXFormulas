using BitMEXFormulas.Common;
using System.Collections.Generic;

namespace BitMEXFormulas.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal accountBalance = 100.5M;

            Order order = new Order()
            {

            };
            
            OrderRiskAssessment orderRiskAssessement = new OrderRiskAssessment(order, accountBalance);


            LadderOrder ladderOrder = new LadderOrder();

            ladderOrder.StartEntryPrice = 100;
            ladderOrder.EndEntryPrice = 200;
            ladderOrder.OrderCount = 4;

            IEnumerable<Order> orderItems = ladderOrder.CreateFlatOrderItems();

            foreach (var item in orderItems)
            {
                System.Console.WriteLine("Item: entry {0}, amount {1}, stoploss{2}, leverage {3}", item.EntryPrice, item.Amount, item.StoplossPrice, item.Leverage);
            }
        }
    }
}
