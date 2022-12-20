using System.Collections.Immutable;

namespace Electrician
{
    internal class Program
    {
        static void Main()
        {
            Random randomizer = new();

            Building building = new(randomizer.Next(3, 26));
            foreach (var floor in building.Floors)
            {
                int apartamentsCount = randomizer.Next(15);
                for (int i = 0; i < apartamentsCount; i++)
                {
                    floor.Apartamentes.Add(new Apartament());
                }
            }

            Electrician elektrik = new Electrician
            {
                Name = "Vasya"
            };

            //Begin checking
            building.Accept(elektrik);
            foreach (var floor in building.Floors)
            {
                floor.Accept(elektrik);
                foreach (var apartament in floor.Apartamentes)
                {
                    apartament.Accept(elektrik);
                }
            }

            Console.WriteLine($"Electrician {elektrik.Name} finished checking. Were checked {elektrik.dbBoxCount} boxex. Were found and corrected {elektrik.ProblemCount} problems.");

            //End of the work shift
            elektrik.Refresh();
        }
    }

    public interface IStructElement
    {
        void Accept(Electrician electrician);

        bool HasProblem { get; }
    }

    public class Building : IStructElement
    {
        public ImmutableList<Floor> Floors { get; }

        public bool HasProblem
            => new Random().Next(100) == 1;

        public Building(int floorAmount)
        {
            List<Floor> list = new();
            for (int i = 0; i < floorAmount; i++)
            {
                list.Add(new Floor());
            }
            Floors = list.ToImmutableList();
        }

        public void Accept(Electrician electrician)
            => electrician.VisitBuildingDBBox(this);
    }

    public class Floor : IStructElement
    {
        public List<Apartament> Apartamentes { get; } = new();

        public bool HasProblem
            => new Random().Next(100) == 1;

        public void Accept(Electrician electrician)
            => electrician.VisitFloorDBBox(this);
    }

    public class Apartament : IStructElement
    {
        public bool HasProblem
            => new Random().Next(100) == 1;

        public void Accept(Electrician electrician)
            => electrician.VisitApartamentDBBox(this);
    }

    public class Electrician //Visitor
    {
        public int dbBoxCount { get; private set; }

        public int ProblemCount { get; private set; }

        public required string Name { get; set; }

        public void Refresh()
            => ProblemCount = 0;

        public void VisitBuildingDBBox(Building building)
        {
            dbBoxCount++;
            if (building.HasProblem)
            {
                ProblemCount++;
            }
        }

        public void VisitFloorDBBox(Floor floor)
        {
            dbBoxCount++;
            if (floor.HasProblem)
            {
                ProblemCount++;
            }
        }

        public void VisitApartamentDBBox(Apartament apartament)
        {
            dbBoxCount++;
            if (apartament.HasProblem)
            {
                ProblemCount++;
            }
        }
    }
}