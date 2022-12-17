namespace CoinTerminalClassLibrary
{
    public class CoinHandleFacade //Facade
    {
        CoinHandler oneHryvniaHandler;
        CoinHandler twoHryvniaHandler;
        CoinHandler fiveHryvniaHandler;
        CoinHandler tenHryvniaHandler;

        public CoinHandleFacade()
        {
            oneHryvniaHandler = new OneHryvniaCoinHandler();
            twoHryvniaHandler = new TwoHryvniaCoinHandler();
            fiveHryvniaHandler = new FiveHryvniaCoinHandler();
            tenHryvniaHandler = new TenHryvniaCoinHandler();
            oneHryvniaHandler.Successor = twoHryvniaHandler;
            twoHryvniaHandler.Successor = fiveHryvniaHandler;
            fiveHryvniaHandler.Successor = tenHryvniaHandler;
        }

        public int CoinHandle(Coin coin)
            => oneHryvniaHandler.CoinHandle(coin);
    }
}