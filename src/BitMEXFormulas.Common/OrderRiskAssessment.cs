using System;
using System.Collections.Generic;
using System.Text;

namespace BitMEXFormulas.Common
{
    public class OrderRiskAssessment
    {
        decimal Risk;

        decimal RiskAccountPercentage;

        int recommendedLeverage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="accountBalance"></param>
        public OrderRiskAssessment(Order order, decimal accountBalance)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="accountBalance"></param>
        public OrderRiskAssessment(LadderOrder order, decimal accountBalance)
        {

        }



    }
}
