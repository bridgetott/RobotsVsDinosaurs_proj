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
        public Herd herd;
        public Fleet fleet;
            

        //constructor (INITIAL VALUES)
        public BattleField()
        {
            herd = new Herd();
            fleet = new Fleet();

        }



        //member methods (CAN DO)

        public void RunAttack()
        {
            //this is first robot attacking first dino
            fleet.robots[0].RobotAttacksDino(herd.dinosaurs[0]);
            herd.dinosaurs[1].DinoAttacksRobot(fleet.robots[2]);
            fleet.robots[1].RobotAttacksDino(herd.dinosaurs[2]);
            herd.dinosaurs[1].DinoAttacksRobot(fleet.robots[0]);
        }

        // run attack of the Dinosaurs and Robots
        // maybe use user imput for who attacks who
        // also use user imput for who wins each attack 

        //public void RunDinoAttack()
        //{
        //    //this is first robot attacking first dino
        //    herd.dinosaurs[1].DinoAttacksRobot(fleet.robots[2]);
        //}

    }
}
