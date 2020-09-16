using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class BattleField
    {

        //member variable (HAS A)
        public Robot robot;
        public Dinosaur dinosaur;
            

        //constructor (INITIAL VALUES)
        public BattleField()
        {
            robot = new Robot;
            dinosaur = new Dinosaur;

        }



        //member methods (CAN DO)

        public void RunAttack();
        
        // run attack of the Dinosaurs and Robots
        // maybe use user imput for who attacks who
        // also use user imput for who wins each attack 
    }
}
