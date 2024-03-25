// subklass

public class weightedCocaCola : CocaCola{
    
    private double weight;

    public weightedCocaCola(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostCola(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 14 kr per cocacola.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of {this.name} is {cost} kr");

    }

}

public class weightedTea : Tea{
    
    private double weight;

    public weightedTea(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostTea(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 2 kr per gram.");
        string weightString = Console.ReadLine();
        int weightInt = int.Parse(weightString);

        double cost = value * (weightInt / 1000);
        Console.WriteLine($"The cost of {this.name} is {cost}");

    }

}

public class weightedButter : Butter{
    
    private double weight;

    public weightedButter(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostButter(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 20 kr per butter.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of the {this.name} is {cost} kr");

    }

}

public class weightedAvocado : Avocado{
    
    private double weight;

    public weightedAvocado(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostAvocado(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 5 kr per avocado.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of the {this.name} is {cost} kr");

    }

}

public class weightedChicken : Chicken{
    
    private double weight;

    public weightedChicken(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostChicken(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 33 kr per chicken.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of the {this.name} is {cost} kr");

    }

}

public class weightedBread : Bread{
    
    private double weight;

    public weightedBread(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostBread(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 15 kr per loaf of bread.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of the {this.name} is {cost} kr");

    }

}

public class weightedMilk : Milk{
    
    private double weight;

    public weightedMilk(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostMilk(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 22 kr per milk container.");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of the {this.name} is {cost} kr");

    }

}

public class weightedCerial : Cerial{
    
    private double weight;

    public weightedCerial(string name, double value) : base(name, value)
    {
        this.weight = weight;
    }

    public override void calcCostCerial(){
        Console.WriteLine($"Please pick the amount of {this.name} you would like to buy, the price is 30 kr per cerial box. ");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        double cost = value*amountInt;
        Console.WriteLine($"The cost of the {this.name} is {cost} kr");

    }

}
