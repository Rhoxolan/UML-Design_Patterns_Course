namespace CoinTerminalClassLibrary
{
    public record Coin
    {
        public required decimal D { get; init; }

        public required decimal Thickness { get; init; }

        public required decimal Mass { get; init; }
    }
}