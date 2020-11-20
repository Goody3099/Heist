using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            List<TeamMember> listOfMembers = new List<TeamMember>();
            Console.WriteLine("Pick a difficultly level for the bank. Pick a number between 90-110");
            string bank = Console.ReadLine();
            int bankDiffLevel = int.Parse(bank);
            while (true)
            {
                Console.WriteLine("Enter a team member's name.");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a team member's skill level.");
                    string skillLevel = Console.ReadLine();
                    int skill = int.Parse(skillLevel);
                    Console.WriteLine("Enter a team member's courage.");
                    string courageLevel = Console.ReadLine();
                    double courage = double.Parse(courageLevel);
                    TeamMember member = new TeamMember(name, skill, courage);
                    listOfMembers.Add(member);
                }

            }
            Console.WriteLine($"Total number of Team Members: {listOfMembers.Count()}");
            int sumOfMemberSkill = listOfMembers.Sum(e => e.skillLevel);
            Console.WriteLine("How many trial runs?");
            string trialRuns = Console.ReadLine();
            int y = int.Parse(trialRuns);
            int x = 0;
            int z = 0;
            Console.WriteLine($"Member Report - {sumOfMemberSkill}");
            while (x < y)
            {
                int heistLuck = randomLuck();
                Console.WriteLine($"Bank Report - {bankDiffLevel + heistLuck}");
                if (sumOfMemberSkill >= bankDiffLevel + heistLuck)
                {
                    Console.WriteLine("Heist Successfull!");
                    z++;
                }
                else
                {
                    Console.WriteLine("Heist failed!");
                }
                x++;
            }
            Console.WriteLine($"Your hesit was sucessfull {z} our of {trialRuns} times.");
        }
        static int randomLuck()
        {
            Random r = new Random();
            int luck = r.Next(-10, 11);
            return luck;
        }
    }
}
