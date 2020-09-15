using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {

        //member variable (HAS A)
        List<Robot> robots;
        List<string> robotNames = new List<string>() { "R2D2", "NumberFive", "RoboGirl" };//come back make a list of names for each robot

        //constructor (INITIAL VALUES)

        public Fleet()
        {
            robots = new List<Robot>();

            for (int i = 0; i < 3; i++)
            {
                Robot differentRobot = new Robot(robotNames[i]);
                robots.Add(differentRobot);
            }
        }

        //member methods (CAN DO)
    }
}
