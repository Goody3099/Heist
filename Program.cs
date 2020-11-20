using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter a team member's name.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a team member's skill level.");
            string skillLevel = Console.ReadLine();
            int skill = int.Parse(skillLevel);
            Console.WriteLine("Enter a team member's courage.");
            string courageLevel = Console.ReadLine();
            double courage = double.Parse(courageLevel);
            Console.WriteLine($@"Name: {name} Skill: {skill} Courge: {courage}");
        }
    }
}
