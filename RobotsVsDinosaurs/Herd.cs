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
        List<Dinosaur> dinosaurs;
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();

            for (int i = 0; i < 3; i++)
            {
                Dinosaur eachDinosaur = new Dinosaur();
                dinosaurs.Add(eachDinosaur);
            }
        }

        //constructor (INITIAL VALUES)

        //member methods (CAN DO)
    }
}
