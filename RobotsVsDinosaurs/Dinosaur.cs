using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {

        //member variable (HAS A)

        public string breed;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;


        //constructor (INITIAL VALUES)
        

        public Dinosaur(string breed)
        {
            this.breed = breed;
            dinoHealth = 100;
            dinoEnergy = 100;
            dinoAttackPower = 10;

        }



        //member methods (CAN DO)

        public void DinoAttacksRobot(Robot robot)
        {
            Console.WriteLine(breed + " is attacking " + robot.name);            
            robot.botHealth -= dinoAttackPower;
            dinoEnergy -= 10;

            if (robot.botHealth > 0)
            {
                Console.WriteLine("Robot's are still alive"); 
                
                
            }
            else
            {
                Console.WriteLine("Dino's win!");
                
            }
        }
    }
}
