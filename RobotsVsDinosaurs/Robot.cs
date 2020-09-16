using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            botHealth = 100;
            powerlevel = 100;            
            botAttackPower = 10;
            weapon = "shotgun";

        }



        //member methods (CAN DO) //attack method
        public void RobotAttacksDino(Dinosaur dinosaur) 
        {
           //Pick a Robot
            //T-Rex health, energy and attack level go down
            //Console.WriteLine("Please pick a Robot that will attack?" ); // how do they know what to pick??
            //string attackingRobot = Console.ReadLine();
            //Console.WriteLine("Please pick a Dinosaur to be attacked?"); //how do they know what to pick??
                                                                         //List<string> robotNames = Console.ReadLine();

            //when Robot and Dinosaur are chosen then Dinos health goes down
            Console.WriteLine(name + " is attacking " + dinosaur.breed + " with it's " + weapon);            
            dinosaur.dinoHealth -= botAttackPower;
            powerlevel -= 10;

            if (dinosaur.dinoHealth == 0)
            {
                Console.WriteLine("Robots win!");
                
            }           
            else
            {
                Console.WriteLine("Dino's are still alive");
                
            }





        }


    }
}
