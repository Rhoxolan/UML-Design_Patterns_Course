namespace CoinTerminalClassLibrary
{
    internal abstract class CoinHandler
    {
        public CoinHandler? Successor { protected get; set; } = null;

        //Template method
        protected virtual int Handler(decimal D, decimal thickness, decimal minMass, decimal maxMass, int val, Coin coin)
        {
            if (coin.D == D && coin.Thickness == thickness && coin.Mass >= minMass && coin.Mass <= maxMass)
            {
                return val;
            }
            if (Successor != null)
            {
                return Successor.CoinHandle(coin);
            }
            return 0;
        }

        public abstract int CoinHandle(Coin coin);
    }

    internal class OneHryvniaCoinHandler : CoinHandler
    {
        public override int CoinHandle(Coin coin)
            => Handler(18.9M, 1.8M, 3.1M, 3.5M, 1, coin);
    }

    internal class TwoHryvniaCoinHandler : CoinHandler
    {
        public override int CoinHandle(Coin coin)
            => Handler(20.2M, 1.8M, 3.8M, 4.2M, 2, coin);
    }

    internal class FiveHryvniaCoinHandler : CoinHandler
    {
        public override int CoinHandle(Coin coin)
            => Handler(22.1M, 2M, 5M, 5.4M, 5, coin);
    }

    internal class TenHryvniaCoinHandler : CoinHandler
    {
        public override int CoinHandle(Coin coin)
            => Handler(23.5M, 2.3M, 6.2M, 6.6M, 10, coin);
    }
}