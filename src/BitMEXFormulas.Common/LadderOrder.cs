using System;
using System.Collections.Generic;
using System.Text;

namespace BitMEXFormulas.Common
{
    class LadderOrder
    {
        string instrument;

        /// <summary>
        /// The price you entered at(or the average)
        /// </summary>
        decimal startEntryPrice;

        /// <summary>
        /// The end of the price you entered at(or the average)
        /// </summary>
        decimal endEntryPrice;


        /// <summary>
        /// Order quantity in units of the instrument (i.e. contracts).
        /// </summary>
        int amount;

        int orderCount;

        int OrderSizeIncreasePercentage;

        /// <summary>
        /// The amount of leverage used for the order
        /// </summary>
        int leverage;

        /// <summary>
        /// The price where your stoploss is
        /// </summary>
        decimal stoplossPrice;

        decimal averagePrice;

        decimal estimatedLiquidationPrice;
    }
}
