using System.Dynamic;

namespace TheRobotFactory;

class Program
{
    static void Main(string[] args)
    {
        int id = 1;
        while (true)
        {
            dynamic robot = new ExpandoObject();
            robot.Id = id;

            Console.Write($"You are producing robot #{robot.Id}.\nDo you want to name this robot? ");
            if (Console.ReadLine() == "yes")
            {
                Console.Write("What is its name? ");
                robot.Name = Console.ReadLine();
            }
            
            Console.Write("Does this robot have a specific size? ");
            if (Console.ReadLine() == "yes")
            {
                Console.Write("What is its height? ");
                robot.Height = Console.ReadLine();
                Console.Write("What is its width? ");
                robot.Width = Console.ReadLine();
            }
            
            Console.Write("Does this robot need to be a specific colour? ");
            if (Console.ReadLine() == "yes")
            {
                Console.Write("What colour? ");
                robot.Colour = Console.ReadLine();
            }
            
            foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot)
                Console.WriteLine($"{property.Key}: {property.Value}");

            id++;
        } 
    }
}