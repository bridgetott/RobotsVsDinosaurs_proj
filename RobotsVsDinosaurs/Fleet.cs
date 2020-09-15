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

        //constructor (INITIAL VALUES)

        public Fleet()
        {
            robots = new List<Robot>();

            for (int i = 0; i < 3; i++)
            {
                Robot differentRobot = new Robot();
                robots.Add(differentRobot);
            }
        }

        //member methods (CAN DO)
    }
}
