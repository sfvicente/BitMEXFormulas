
# _BitMEX_ Formulas
The Bitcoin Mercantile Exchange  _BitMEX_ is a trading platform that offers investors access to the global financial markets using only Bitcoin.



## General Formulas

### Risk

> RiskPercentage = ((EntryPrice — StopLoss) / EntryPrice) * 100



## Product Specific Formulas

### Liquidation Price
Most _BitMEX_ contracts are highly leveraged. To keep these positions open, traders are required to hold a percentage of the value of the position on the exchange, known as the Maintenance Margin percentage. If you cannot fulfill your maintenance requirement, you will be liquidated and your maintenance margin will be lost.
The liquidation price is the price at which you have exhausted your MMR and it is the price at which your position will be closed.

### Leverage
Sometimes referred to as margin trading, leverage trading involves borrowing funds to amplify potential returns when buying and selling cryptocurrency. When you leverage trade, you can access increased buying power and may open positions that are much larger than your actual account balance.
Leverage trading is speculative and riskier than non-leveraged trading.


### _XBTUSD_ Formulas
_XBTUSD_ is a leveraged trading product that allows traders to speculate on the Bitcoin/USD exchange rate with up to 100x leverage.

#### Liquidation
Long or short?
liq = entry / (1 + ((1/Leverage) + 0.0015) - 0.0066)


Long Entry
> ?

Short Entry
> ?




#### Leverage

Long Entry
> ?

Short Entry
> ?






### _ETHUSD_
_ETHUSD_ is a leveraged trading product that allows traders to speculate on the Ethereum/USD exchange rate with up to 50x leverage.



#### Liquidation

**Long Entry**
> LiquidationPrice = EntryPrice * (1.01 - 1 / Leverage + 1/10000) 
and rounded up to nearest 0.05 (ceiling)

**Short Entry**
 > LiquidationPrice = -EntryPrice * (-0,99-1 / Leverage + 1 / 10000)
 or?
 > LiquidationPrice = EntryPrice * (1 + 1 / Leverage - 1/100)
floor 0.05


#### Leverage

**Long Entry**
> Leverage = Math.Floor((-1.0015) / ((LiquidationPrice / EntryPrice) - 1.0015 - 0,01))

**Short Entry**
> Leverage = 1 / (LiquidationPrice / EntryPrice - 0.99)





### LTC

#### Liquidation

Long Entry
> LiquidationPrice =(EntryPrice - (EntryPrice * ((1/Leverage) + 0,005))) +(EntryPrice * 0,02)

Short Entry
> ?




#### Leverage

Long Entry
> ?

Short Entry
> ?
