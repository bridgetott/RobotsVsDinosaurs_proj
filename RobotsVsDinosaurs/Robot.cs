using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {

        //member variable (HAS A)

        public string name;
        public int botHealth;
        public int powerlevel;
        public string weapon; //maybe make a list of weapons or pull from the weapons class!!!
        public int botAttackPower;



        //constructor (INITIAL VALUES)

        public Robot(string name)
      
        {
            this.name = name;
            botHealth = 5;
            powerlevel = 100;            
            botAttackPower = 10;
            weapon = "";

        }



        //member methods (CAN DO) //attack method
        public void RobotAttacksDino(string robotNames, string dinosaurNames) 
        {
            //numberFive is going to attack T-Rex
            //T-Rex health, energy and attack level go down
            string result = Console.ReadLine();
            bool hit = true;
            int Dinosaur.dinoEnergy -=

           
        }


    }
}
