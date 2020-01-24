namespace BitMEXFormulas.Common
{
    public class Order
    {
        /// <summary>
        /// The price you entered at(or the average)
        /// </summary>
        public decimal EntryPrice;

        /// <summary>
        /// Order quantity in units of the instrument (i.e. contracts).
        /// </summary>
        public int Amount;

        /// <summary>
        /// The amount of leverage used for the order
        /// </summary>
        public int Leverage;

        /// <summary>
        /// The price where your stoploss is
        /// </summary>
        public decimal StoplossPrice;

        public decimal EstimatedLiquidationPrice;
    }
}
