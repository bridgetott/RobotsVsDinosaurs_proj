using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {

        //member variable (HAS A)
        public List<Dinosaur> dinosaurs;
        List<string> dinosaurNames = new List<string>() { "T-Rex", "Stegosaurus", "Raptor" };//come back make a list of names for each dino

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();

            for (int i = 0; i < 3; i++)
            {
                Dinosaur eachDinosaur = new Dinosaur(dinosaurNames[i]);
                dinosaurs.Add(eachDinosaur);
            }
        }

        //constructor (INITIAL VALUES)

        //member methods (CAN DO)
    }
}
