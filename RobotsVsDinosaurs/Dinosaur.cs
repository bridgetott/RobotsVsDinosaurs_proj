using System;
using System.Collections.Generic;
using System.Linq;
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
            dinoHealth = 5;
            dinoEnergy = 100;
            dinoAttackPower = 10;

        }
        


        //member methods (CAN DO)
    }
}
