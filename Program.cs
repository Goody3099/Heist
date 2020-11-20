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

            if (sumOfMemberSkill >= bankDiffLevel)
            {
                Console.WriteLine("Heist Successfull!");
            }
            else
            {
                Console.WriteLine("Heist failed!");
            }
        }
    }
}
