namespace GameWorld
{
    internal class Program
    {
        static void Main()
        {
            World firstWorld = new();
            World secondWorld = new();

            firstWorld.AddBeing(new Being(new PlantFactory(), "Oak"));
            firstWorld.AddBeing(new Being(new HerbivertFactory(), "Cow"));

            secondWorld.AddBeing(new Being(new PlantFactory(), "Maple"));
            secondWorld.AddBeing(new Being(new HerbivertFactory(), "Goat"));
            secondWorld.AddBeing(new Being(new PredatorFactory(), "Wolf"));

            Console.WriteLine($"Top of the food chain in the First World - {firstWorld.GetTopEntityName()}");
            Console.WriteLine($"Top of the food chain in the Second World - {secondWorld.GetTopEntityName()}");
        }
    }

    enum Level
    {
        None,
        Low,
        High,
        Max
    }

    abstract class BeingFactory
    {
        public abstract Level CreateLevel();
    }

    class PlantFactory : BeingFactory
    {
        public override Level CreateLevel()
        {
            return Level.Low;
        }
    }

    class HerbivertFactory : BeingFactory
    {
        public override Level CreateLevel()
        {
            return Level.High;
        }
    }

    class PredatorFactory : BeingFactory
    {
        public override Level CreateLevel()
        {
            return Level.Max;
        }
    }

    class Being
    {
        private string name;
        private Level level;

        public Being(BeingFactory factory, string name)
        {
            this.name = name;
            level = factory.CreateLevel();
        }

        public Level Level
        {
            get
            {
                return level;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }

    class World
    {
        private List<Being> beings = new();

        public void AddBeing(Being being)
        {
            beings.Add(being);
        }

        public void RemoveBeing(Being being)
        {
            beings.Remove(being);
        }

        public string GetTopEntityName()
        {
            return beings.OrderByDescending(b => b.Level).FirstOrDefault()!.Name;
        }
    }

}