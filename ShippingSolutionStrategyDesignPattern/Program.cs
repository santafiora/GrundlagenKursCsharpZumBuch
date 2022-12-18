/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingSolutionStrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/

using System;

namespace StrategyPatternExample
{
    public class Package
    {
        public decimal Weight { get; set; }
        public string Destination { get; set; }
    }

    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(Package package);
    }

    public class GroundShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Package package)
        {
            // Calculate the cost of ground shipping based on the weight and destination of the package
            // (This is just an example; you should use real shipping rates)
            decimal costPerPound = package.Destination == "USA" ? 0.5m : 1.0m;
            return package.Weight * costPerPound;
        }
    }

    public class AirShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Package package)
        {
            // Calculate the cost of air shipping based on the weight and destination of the package
            // (This is just an example; you should use real shipping rates)
            decimal costPerPound = package.Destination == "USA" ? 1.0m : 2.0m;
            return package.Weight * costPerPound;
        }
    }

    public class ShippingCalculator
    {
        private readonly IShippingStrategy _shippingStrategy;

        public ShippingCalculator(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public decimal CalculateCost(Package package)
        {
            return _shippingStrategy.CalculateShippingCost(package);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var package = new Package { Weight = 10, Destination = "USA" };

            var groundCalculator = new ShippingCalculator(new GroundShippingStrategy());
            var airCalculator = new ShippingCalculator(new AirShippingStrategy());

            Console.WriteLine(groundCalculator.CalculateCost(package));  // Output: 5
            Console.WriteLine(airCalculator.CalculateCost(package));  // Output: 10
            Console.ReadKey();
        }
    }
}
