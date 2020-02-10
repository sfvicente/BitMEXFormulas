using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitMEXFormulas.Common
{
    public class LadderOrder
    {
        public string Instrument;

        /// <summary>
        /// The price you entered at(or the average)
        /// </summary>
        public decimal StartEntryPrice;

        /// <summary>
        /// The end of the price you entered at(or the average)
        /// </summary>
        public decimal EndEntryPrice;


        /// <summary>
        /// Order quantity in units of the instrument (i.e. contracts).
        /// </summary>
        public int Amount;

        public int OrderCount;

        public int OrderSizeIncreasePercentage;

        public ScaledOrderDistribution ScaledOrderDistribution;

        /// <summary>
        /// The amount of leverage used for the order
        /// </summary>
        public int Leverage;

        /// <summary>
        /// The price where your stoploss is
        /// </summary>
        public decimal StoplossPrice;

        public decimal AveragePrice;

        public decimal EstimatedLiquidationPrice;


        public List<Order> CreateOrderItems()
        {
            var orderItems = new List<Order>();

            return orderItems;
        }

        public IEnumerable<Order> CreateFlatOrderItems()
        {
            // ToDo: Validate arguments

            if (OrderCount == 1)
            {
                return Enumerable.Empty<Order>();
            }

            var orderItems = new List<Order>();

            if (OrderCount == 2)
            {
                orderItems.Add(new Order()
                {
                    EntryPrice = this.StartEntryPrice,
                    Amount = this.Amount / 2,
                    Leverage = this.Leverage,
                    StoplossPrice = this.StoplossPrice
                });

                orderItems.Add(new Order()
                {
                    EntryPrice = this.EndEntryPrice,
                    Amount = this.Amount / 2,
                    Leverage = this.Leverage,
                    StoplossPrice = this.StoplossPrice
                });

                return orderItems;
            }

            if (OrderCount > 2)
            {
                decimal intervalSize = (EndEntryPrice - StartEntryPrice);
                decimal chunkSize = intervalSize / (OrderCount - 1);
                int orderItemAmount = this.Amount / OrderCount;

                for(int i = 0; i < this.OrderCount; i++)
                {
                    Order orderItem = new Order()
                    {
                        EntryPrice = StartEntryPrice + (chunkSize * i),
                        StoplossPrice = this.StoplossPrice,
                        Amount = orderItemAmount,
                        Leverage = this.Leverage,
                    };

                    orderItems.Add(orderItem);
                }
            }

            return orderItems;
        }
    }
}
