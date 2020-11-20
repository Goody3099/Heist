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
            int bankDiffLevel = 100;
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
            Console.WriteLine($"Member Report - {sumOfMemberSkill}");
            while (x < y)
            {
                int heistLuck = randomLuck();
                Console.WriteLine($"Bank Report - {bankDiffLevel + heistLuck}");
                if (sumOfMemberSkill >= bankDiffLevel + heistLuck)
                {
                    Console.WriteLine("Heist Successfull!");
                }
                else
                {
                    Console.WriteLine("Heist failed!");
                }
                x++;
            }

        }
        static int randomLuck()
        {
            Random r = new Random();
            int luck = r.Next(-10, 11);
            return luck;
        }
    }
}
