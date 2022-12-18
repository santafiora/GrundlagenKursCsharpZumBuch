/*using System;
using System.Collections.Generic;

namespace RobotStrategyPatternExample
{
    public class Field
    {
        public const int Size = 10;
        public bool[,] Grid { get; set; }

        public Field()
        {
            Grid = new bool[Size, Size];
        }

        public void PlaceObstacle(int x, int y)
        {
            Grid[x, y] = true;
        }

        public bool IsObstacleAt(int x, int y)
        {
            return Grid[x, y];
        }
    }

    public interface INavigationStrategy
    {
        bool CanMoveTo(Field field, int x, int y);
    }

    public class AvoidObstaclesStrategy : INavigationStrategy
    {
        public bool CanMoveTo(Field field, int x, int y)
        {
            return !field.IsObstacleAt(x, y);
        }
    }

    public class IgnoreObstaclesStrategy : INavigationStrategy
    {
        public bool CanMoveTo(Field field, int x, int y)
        {
            return true;
        }
    }

    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public INavigationStrategy NavigationStrategy { get; set; }

        public Robot()
        {
            X = 0;
            Y = 0;
        }

        public void MoveTo(Field field, int x, int y)
        {
            if (NavigationStrategy.CanMoveTo(field, x, y))
            {
                X = x;
                Y = y;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();
            var random = new Random();

            // Place some obstacles on the field
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(Field.Size);
                int y = random.Next(Field.Size);
                field.PlaceObstacle(x, y);
            }

            // Create a robot with the AvoidObstaclesStrategy
            var robot = new Robot
            {
                NavigationStrategy = new AvoidObstaclesStrategy()
            };

            // Print the initial position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");

            // Move the robot to a random location
            int x = random.Next(Field.Size);
            int y = random.Next(Field.Size);
            robot.MoveTo(field, x, y);

            // Print the final position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");

            // Change the robot's navigation strategy to IgnoreObstaclesStrategy
            robot.NavigationStrategy = new IgnoreObstaclesStrategy();

            // Move the robot to a random location
            x = random.Next(Field.Size);
            y = random.Next(Field.Size);
            robot.MoveTo(field, x, y);

            // Print the final position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");
        }
    }
}*/
/*
using System;
using System.Collections.Generic;

namespace RobotStrategyPatternExample
{
    public class Field
    {
        public const int Size = 10;
        public bool[,] Grid { get; set; }

        public Field()
        {
            Grid = new bool[Size, Size];
        }

        public void PlaceObstacle(int x, int y)
        {
            Grid[x, y] = true;
        }

        public bool IsObstacleAt(int x, int y)
        {
            return Grid[x, y];
        }
    }

    public interface INavigationStrategy
    {
        bool CanMoveTo(Field field, int x, int y);
    }

    public class AvoidObstaclesStrategy : INavigationStrategy
    {
        public bool CanMoveTo(Field field, int x, int y)
        {
            return !field.IsObstacleAt(x, y);
        }
    }

    public class IgnoreObstaclesStrategy : INavigationStrategy
    {
        public bool CanMoveTo(Field field, int x, int y)
        {
            return true;
        }
    }

    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public INavigationStrategy NavigationStrategy { get; set; }

        public Robot()
        {
            X = 0;
            Y = 0;
        }

        public void MoveTo(Field field, int x, int y)
        {
            if (NavigationStrategy.CanMoveTo(field, x, y))
            {
                X = x;
                Y = y;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();
            var random = new Random();

            // Place some obstacles on the field
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(Field.Size);
                int y = random.Next(Field.Size);
                field.PlaceObstacle(x, y);
            }

            // Create a robot with the AvoidObstaclesStrategy
            var robot = new Robot
            {
                NavigationStrategy = new AvoidObstaclesStrategy()
            };

            // Print the initial position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");
            Console.ReadKey();

            // Move the robot to a random location
            int targetX = random.Next(Field.Size);
            int targetY = random.Next(Field.Size);
            robot.MoveTo(field, targetX, targetY);

            // Print the final position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");
            Console.ReadKey();

            // Change the robot's navigation strategy to IgnoreObstaclesStrategy
            robot.NavigationStrategy = new IgnoreObstaclesStrategy();
            Console.ReadKey();
            // Move the robot to a random location
            targetX = random.Next(Field.Size);
            targetY = random.Next(Field.Size);
            robot.MoveTo(field, targetX, targetY);

            // Print the final position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");
            Console.ReadKey();
        }
    }
}*/


/*using System;
using System.Collections.Generic;

namespace RobotStrategyPatternExample
{
    public class Field
    {
        public const int Size = 10;
        public bool[,] Grid { get; set; }

        public Field()
        {
            Grid = new bool[Size, Size];
        }

        public void PlaceObstacle(int x, int y)
        {
            Grid[x, y] = true;
        }

        public bool IsObstacleAt(int x, int y)
        {
            return Grid[x, y];
        }
    }

    public interface INavigationStrategy
    {
        bool CanMoveTo(Field field, int x, int y);
    }

    public class AvoidObstaclesStrategy : INavigationStrategy
    {
        public bool CanMoveTo(Field field, int x, int y)
        {
            return !field.IsObstacleAt(x, y);
        }
    }

    public class IgnoreObstaclesStrategy : INavigationStrategy
    {
        public bool CanMoveTo(Field field, int x, int y)
        {
            return true;
        }
    }

    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public INavigationStrategy NavigationStrategy { get; set; }

        public Robot()
        {
            X = 0;
            Y = 0;
        }

        public void MoveTo(Field field, int x, int y)
        {
            if (NavigationStrategy.CanMoveTo(field, x, y))
            {
                X = x;
                Y = y;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();
            var random = new Random();

            // Place some obstacles on the field
            Console.WriteLine("Placing obstacles on the field...");
            Console.ReadKey();
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(Field.Size);
                int y = random.Next(Field.Size);
                field.PlaceObstacle(x, y);
            }
            Console.ReadKey();

            // Create a robot with the AvoidObstaclesStrategy
            Console.WriteLine("Creating robot with AvoidObstaclesStrategy...");
            var robot = new Robot
            {
                NavigationStrategy = new AvoidObstaclesStrategy()
            };
            Console.ReadKey();

            // Print the initial position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");
            Console.ReadKey();

            // Move the robot to a random location
            Console.WriteLine("Moving robot to a random location...");
            Console.ReadKey();
            int targetX = random.Next(Field.Size);
            int targetY = random.Next(Field.Size);
            robot.MoveTo(field, targetX, targetY);

            // Print the final position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");
            Console.ReadKey();


            // Change the robot's navigation strategy to IgnoreObstaclesStrategy
            Console.WriteLine("Changing robot's navigation strategy to IgnoreObstaclesStrategy...");
            robot.NavigationStrategy = new IgnoreObstaclesStrategy();
            Console.ReadKey();

            // Move the robot to a random location
            Console.WriteLine("Moving robot to a random location...");
            targetX = random.Next(Field.Size);
            targetY = random.Next(Field.Size);
            robot.MoveTo(field, targetX, targetY);
            Console.ReadKey();

            // Print the final position of the robot
            Console.WriteLine($"Robot position: ({robot.X}, {robot.Y})");

            Console.ReadKey();
        }
    }
}



*/


using System;

namespace SingletonExample
{
    // The "Singleton" class
    public class SchoolBus
    {
        // The static field that will hold the single instance of the class
        private static SchoolBus instance;

        // A private constructor to prevent other classes from creating an instance of the school bus
        private SchoolBus() { }

        // The static method that returns the single instance of the class
        public static SchoolBus GetInstance()
        {
            // If the instance doesn't exist yet, create it
            if (instance == null)
            {
                instance = new SchoolBus();
            }

            // Return the single instance
            return instance;
        }

        // A method for the school bus to pick up students
        public void PickUpStudents()
        {
            Console.WriteLine("Picking up students...");
            // Imaginary code to pick up students goes here
            Console.WriteLine("Done!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Pause the console to give the kids time to read the output
            Console.WriteLine("Press any key to start using the school bus...");
            Console.ReadKey();

            // Get the single instance of the school bus
            SchoolBus bus = SchoolBus.GetInstance();

            // Use the school bus to pick up some students
            Console.WriteLine("Requesting a pickup...");
            bus.PickUpStudents();

            // Pause the console again
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
