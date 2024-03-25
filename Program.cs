namespace Myshop;

class Program
{
    static void Main(string[] args)
    {

        CocaCola myCocaCola = new CocaCola("CocaCola", 14);
        Tea myTea = new Tea("Tea", 2);
        Butter myButter = new Butter("Butter", 20);
        Avocado myAvocado = new Avocado("Avocado", 5);
        Chicken myChicken = new Chicken("Chicken", 33);
        Bread myBread = new Bread("Bread", 15);
        Milk myMilk = new Milk("Milk", 22);
        Cerial myCerial = new Cerial("Cerial", 30);

        Console.WriteLine($"Welcome to my shop, what would you like to buy. Pick between, {myCocaCola}, {myTea}, {myButter}, {myAvocado}, {myChicken}, {myBread}, {myMilk} and {myCerial}:");
        string answer = Console.ReadLine();

        if (answer == "CocaCola")
        {
            weightedCocaCola wCocaCola = new weightedCocaCola("CocaCola", 14);
            wCocaCola.calcCostCola();
        }

        if (answer == "Tea")
        {
            weightedTea wTea = new weightedTea("Tea", 2);
            wTea.calcCostTea();
        }

        if (answer == "Butter")
        {
            weightedButter wButter = new weightedButter("Butter", 20);
            wButter.calcCostButter();
        }

        if (answer == "Avocado")
        {
            weightedAvocado wAvocado = new weightedAvocado("Avocado", 5);
            wAvocado.calcCostAvocado();
        }

        if (answer == "Chicken")
        {
            weightedChicken wChicken = new weightedChicken("Chicken", 33);
            wChicken.calcCostChicken();
        }
        
        if (answer == "Bread")
        {
            weightedBread wBread = new weightedBread("Bread", 15);
            wBread.calcCostBread();
        }

        if (answer == "Milk")
        {
            weightedMilk wMilk = new weightedMilk("Milk", 22);
            wMilk.calcCostMilk();
        }

        if (answer == "Cerial")
        {
            weightedCerial wCerial = new weightedCerial("Cerial", 30);
            wCerial.calcCostCerial();
        }
        
    }
}
