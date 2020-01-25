using System;
using System.Collections.Generic;
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
    }
}
