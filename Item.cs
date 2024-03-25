public class CocaCola
{
    // attribut
    protected string name;
    protected double value;

    // konstruktor 
    public CocaCola(string name, double value)
    {
        this.name = name;
        this.value = value;

    }

    public virtual void calcCostCola()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy the price is 14 kr per cocacola.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }

}


public class Tea
{
    // attribut
    protected string name;
    protected double value;

    // konstruktor 
    public Tea(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostTea()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 2 kr per gram. ");
        string weightString = Console.ReadLine();
        int weightInt = int.Parse(weightString);

        double cost = value * (weightInt/1000);
        Console.WriteLine($"The cost of {this.name} is {cost}");
    }

}

public class Butter
{
    //attribut 
    protected string name;
    protected double value;

    public Butter(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostButter()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 20 kr per butter.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }
}

public class Avocado
{
    //attribut 
    protected string name;
    protected double value;

    public Avocado(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostAvocado()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 5 kr per avocado.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }
}

public class Chicken
{
    //attribut 
    protected string name;
    protected double value;

    public Chicken(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostChicken()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 33 kr per chicken.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }
}

public class Bread
{
    //attribut 
    protected string name;
    protected double value;

    public Bread(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostBread()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 15 kr per loaf of bread.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }
}

public class Milk
{
    //attribut 
    protected string name;
    protected double value;

    public Milk(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostMilk()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 22 kr per milk container.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }
}

public class Cerial
{
    //attribut 
    protected string name;
    protected double value;

    public Cerial(string name, double value)
    {
        this.name = name;
        this.value = value;
    }

    public virtual void calcCostCerial()
    {
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 30 kr per cerial box. ");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);

        double cost = value * amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");
    }
}
