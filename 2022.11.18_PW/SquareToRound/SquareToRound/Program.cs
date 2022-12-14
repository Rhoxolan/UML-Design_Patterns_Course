using System.Diagnostics.CodeAnalysis;

namespace SquareToRound
{
    internal class Program
    {
        static void Main()
        {
            RoundHole hole = new RoundHole
            {
                D = 10
            };

            SquarePeg squarePeg = new SquarePeg
            {
                Side = 5
            };

            RoundPeg roundPeg = new SquareToRoundAdapter(squarePeg);

            Console.WriteLine(hole.Fits(roundPeg));
        }
    }

    class RoundHole //Client
    {
        public required double D { get; init; }

        public bool Fits(RoundPeg roundPeg)
            => roundPeg.D <= D;
    }

    class SquarePeg //Adaptee
    {
        public required double Side { get; init; }
    }

    class RoundPeg //Target
    {
        public required double D { get; init; }
    }

    class SquareToRoundAdapter : RoundPeg //Adapter
    {
        [SetsRequiredMembers]
        public SquareToRoundAdapter(SquarePeg squarePeg)
        {
            D = squarePeg.Side / Math.Sqrt(2) * 2;
        }
    }

}