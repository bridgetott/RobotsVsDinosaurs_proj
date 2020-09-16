using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Fleet robots = new Fleet();
        //    Herd dinosaurs = new Herd();
        //}

        {
            BattleField battlefield = new BattleField();
            battlefield.RunAttack();
            Console.ReadLine();

        }



    }
}
