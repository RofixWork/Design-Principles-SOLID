using solid_principals;

Pizza? pizza = Pizza.Order("chickden");

if(pizza == null)
    Console.WriteLine("Not exist this pizza type");
else
    Console.WriteLine(pizza);

public class Pizza
{
    public virtual string Name { get => $"{GetType().Name}"; }
    public virtual decimal Price { get => 10m; }

    public static Pizza? Create(string type)
    {
        Pizza? pizza = type.ToLower() switch
        {
            PizzaConstants.PizzaChese => new Chese(),
            PizzaConstants.PizzaChicken => new Chicken(),
            PizzaConstants.PizzaVegetirian => new Vegitirian(),
            _ => null,
        };
        return pizza;
    }

    public static Pizza? Order(string type)
    {
        Pizza? pizza = Create(type);
        if(pizza is not null)
        {
            Prepare();
            Cook();
            Cut();
        }

        return pizza;
    }
    public static void Prepare()
    {
        Console.Write("Preparing...");
        Thread.Sleep(500);
        Console.WriteLine(" Complete");
    }
    public static void Cook()
    {
        Console.Write("Cooking...");
        Thread.Sleep(500);
        Console.WriteLine(" Complete");
    }

    public static void Cut()
    {
        Console.Write("cutting and boxing...");
        Thread.Sleep(500);
        Console.WriteLine(" Complete");
    }

    public override string ToString()
    {
        return $"Pizza Name: {Name} | Price: ${Price}";
    }
}

public class Chese : Pizza
{
    public override string Name => $"{nameof(Pizza)} {GetType().Name}";

    public override decimal Price => base.Price + 3m;
}
public class Chicken : Pizza
{
    public override string Name => $"{nameof(Pizza)} {GetType().Name}";

    public override decimal Price => base.Price + 6m;
}

public class Vegitirian : Pizza
{
    public override string Name => $"{nameof(Pizza)} {GetType().Name}";

    public override decimal Price => base.Price + 6m;

    public string Type => "Vegetirian";

    public override string ToString()
    {
        return $"{base.ToString()} | Type: {Type}";
    }
}
