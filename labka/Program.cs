using System;
public abstract class Bird
{
    
    public int Age { get; set; }
    
   
    public abstract string Fly();
}


public class FlyingBird : Bird
{
    // метод максимальної висоти польоту
    public int MaxFlightHeight { get; set; }
    
    public FlyingBird(int age, int maxFlightHeight)
    {
        Age = age;
        MaxFlightHeight = maxFlightHeight;
    }

    // Реалізація методу Fly
    public override string Fly()
    {
        return $"This bird can fly up to {MaxFlightHeight} meters high.";
    }
}

//  NonFlyingBird, що розширює клас Bird для нелітаючих птахів
public class NonFlyingBird : Bird
{
    public int RunningSpeed { get; set; }
    
    public NonFlyingBird(int age, int runningSpeed)
    {
        Age = age;
        RunningSpeed = runningSpeed;
    }
    public override string Fly()
    {
        return "This bird cannot fly.";
    }
    public string Run()
    {
        return $"This bird can run at a speed of {RunningSpeed} km/h.";
    }
}

class Pupok
{
    static void Main(string[] args)
    {
        
        FlyingBird eagle = new FlyingBird(5, 10000);
        FlyingBird parrot = new FlyingBird(2, 5000);
        NonFlyingBird ostrich = new NonFlyingBird(8, 70);
        NonFlyingBird penguin = new NonFlyingBird(3, 20);
        Console.WriteLine("Eagle: " + eagle.Fly());
        Console.WriteLine("Parrot: " + parrot.Fly());
        Console.WriteLine("Ostrich: " + ostrich.Fly() + " " + ostrich.Run());
        Console.WriteLine("Penguin: " + penguin.Fly() + " " + penguin.Run());
    }
}
