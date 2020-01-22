using System;

namespace BitMEXFormulas.Common
{
    public class Order
    {
        /// <summary>
        /// The price you entered at(or the average)
        /// </summary>
        decimal entryPrice;

        /// <summary>
        /// Order quantity in units of the instrument (i.e. contracts).
        /// </summary>
        int amount;

        /// <summary>
        /// The amount of leverage used for the order
        /// </summary>
        int leverage;

        /// <summary>
        /// The price where your stoploss is
        /// </summary>
        decimal stoplossPrice;
    }
}
