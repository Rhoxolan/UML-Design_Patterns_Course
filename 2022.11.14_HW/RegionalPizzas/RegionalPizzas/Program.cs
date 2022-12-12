using static System.Environment;

namespace RegionalPizzas
{
    internal class Program
    {
        static void Main()
        {
            Pizza schoolPizza = new(new SchoolPizzaFactory());
            Pizza bestPizza = new(new BestPizzaFactory());

            Console.WriteLine($"Price of the Best Pizza - {bestPizza.GetPrice()}{NewLine}" +
                $"Ingridients:{NewLine}{bestPizza}");

            Console.WriteLine($"Price of the School Pizza - {schoolPizza.GetPrice()}{NewLine}" +
                $"Ingridients:{NewLine}{schoolPizza}");
        }
    }

    abstract class Cheese
    {
        public abstract string Name { get; }

        public abstract double Price { get; }
    }

    class Mozarella : Cheese
    {
        public override string Name => "Mozarella";

        public override double Price => 35;
    }

    class Parmesan : Cheese
    {
        public override string Name => "Parmesan";

        public override double Price => 31.5;
    }

    class Smetankkovy : Cheese
    {
        public override string Name => "Smetankkovy";

        public override double Price => 15;
    }

    abstract class Sause
    {
        public abstract string Name { get; }

        public abstract double Price { get; }
    }

    class Tomato : Sause
    {
        public override string Name => "Tomato";

        public override double Price => 7;
    }

    class Barbecue : Sause
    {
        public override string Name => "Barbecue";
        public override double Price => 7.5;
    }

    class Mayonez : Sause
    {
        public override string Name => "Mayonez";
        public override double Price => 3.5;
    }

    abstract class Base
    {
        public abstract string Name { get; }

        public abstract double Price { get; }
    }

    class Standart : Base
    {
        public override string Name => "Standart base";

        public override double Price => 25;
    }

    class XXL : Base
    {
        public override string Name => "XXL base";

        public override double Price => 25;
    }

    class School : Base
    {
        public override string Name => "School base";

        public override double Price => 11.35;
    }

    abstract class Addon
    {
        public abstract string Name { get; }

        public abstract double Price { get; }
    }

    class Mushrooms : Addon
    {
        public override string Name => "Mushrooms";

        public override double Price => 15;
    }

    class Seafood : Addon
    {
        public override string Name => "Seafood";

        public override double Price => 17.5;
    }

    class Sausage : Addon
    {
        public override string Name => "Sausage";

        public override double Price => 12.5;
    }

    abstract class PizzaFactory //Abstract factory
    {
        public abstract Cheese CreateCheese();

        public abstract Sause CreateSause();

        public abstract Base CreateBase();

        public abstract Addon CreateAddon();
    }

    class BestPizzaFactory : PizzaFactory
    {
        public override Addon CreateAddon()
        {
            return new Seafood();
        }

        public override Base CreateBase()
        {
            return new XXL();
        }

        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public override Sause CreateSause()
        {
            return new Barbecue();
        }
    }

    class StandartPizzaFactory : PizzaFactory
    {
        public override Addon CreateAddon()
        {
            return new Mushrooms();
        }

        public override Base CreateBase()
        {
            return new Standart();
        }

        public override Cheese CreateCheese()
        {
            return new Parmesan();
        }

        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }

    class SchoolPizzaFactory : PizzaFactory
    {
        public override Addon CreateAddon()
        {
            return new Sausage();
        }

        public override Base CreateBase()
        {
            return new School();
        }

        public override Cheese CreateCheese()
        {
            return new Smetankkovy();
        }

        public override Sause CreateSause()
        {
            return new Mayonez();
        }
    }

    class Pizza
    {
        private Addon addon;
        private Base pizzaBase;
        private Cheese cheese;
        private Sause sause;

        public Pizza(PizzaFactory factory)
        {
            addon = factory.CreateAddon();
            pizzaBase = factory.CreateBase();
            cheese = factory.CreateCheese();
            sause = factory.CreateSause();
        }

        //public required Addon Addon
        //{
        //    init
        //    {
        //        addon = value;
        //    }
        //}

        //public required Base PizzaBase
        //{
        //    init
        //    {
        //        pizzaBase = value;
        //    }
        //}

        //public required Cheese Cheese
        //{
        //    init
        //    {
        //        cheese = value;
        //    }
        //}

        //public required Sause Sause
        //{
        //    init
        //    {
        //        sause = value;
        //    }
        //}

        public double GetPrice()
        {
            return addon.Price + pizzaBase.Price + cheese.Price + sause.Price;
        }

        public override string ToString()
        {
            return $"Base - {pizzaBase.Name}{NewLine}" +
                $"Cheese - {cheese.Name}{NewLine}" +
                $"Sause - {sause.Name}{NewLine}" +
                $"Addon - {addon.Name}{NewLine}";
        }

    }
}
