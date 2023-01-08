// See https://aka.ms/new-console-template for more information
using DesignPattern.DesignPattern;

Console.WriteLine("Hello, World!");


#region StrategyAndFactory

// Usage
var fare = new FareCalculator("StandardCar");
Console.WriteLine(fare.CalculateFare(100)); 
// Output: 50

fare = new FareCalculator("LuxuryCar");
Console.WriteLine(fare.CalculateFare(100));
// Output: 70

fare = new FareCalculator("Minivan");
Console.WriteLine(fare.CalculateFare(100));
// Output: 90
#endregion

#region DecoratorPattern
Lightsaber lightsaber = new HiltDesignDecorator(new BladeColorDecorator(new StandardLightsaber(), "green"), "gold");
lightsaber.Assemble();
#endregion