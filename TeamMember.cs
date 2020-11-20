using System;

namespace Heist
{
    public class TeamMember
    {
        public string name;
        public int skillLevel;
        public double courage;
        public TeamMember(string x, int y, double z)
        {
            name = x;
            skillLevel = y;
            courage = z;

        }
    }
}