namespace Homework1;

public class Car
{
    public string name { get; set; }
    public string gearType{get;set;}

    public Car()
    {
        name = "Araba";
        gearType = "Belirtilmemiş";

    }

    public void display()
    {
        Console.WriteLine($"{name}->{gearType}");
    }
}