using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPattern
{
    // The base Strategy interface
    public interface IFareStrategy
    {
        double CalculateFare(int distance);
    }

    // Concrete Strategies
    public class StandardCarFare : IFareStrategy
    {
        public double CalculateFare(int distance)
        {
            return distance * 0.5;
        }
    }

    public class LuxuryCarFare : IFareStrategy
    {
        public double CalculateFare(int distance)
        {
            return distance * 0.7;
        }
    }

    public class MinivanFare : IFareStrategy
    {
        public double CalculateFare(int distance)
        {
            return distance * 0.9;
        }
    }

    public class TaxiFareMethodFactory
    {
        public static IFareStrategy CreateFareMethod(string type)
        {
            if (type == "StandardCar")
            {
                return new StandardCarFare();
            }
            else if (type == "LuxuryCar")
            {
                return new LuxuryCarFare();
            }
            else if (type == "Minivan")
            {
                return new MinivanFare();
            }
            else
            {
                throw new ArgumentException("Invalid fare method type");
            }
        }
    }

    // The Context
    public class FareCalculator
    {
        private IFareStrategy _fareStrategy;

        public FareCalculator(string fareType)
        {
            _fareStrategy = TaxiFareMethodFactory.CreateFareMethod(fareType);
        }

        public double CalculateFare(int distance)
        {
            return _fareStrategy.CalculateFare(distance);
        }
    }
}
