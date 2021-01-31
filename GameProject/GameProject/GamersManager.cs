using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamersManager : IGamersManager
    {
        public void Delete(Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName +" " + "deleted!");
        }

        public void Save(Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "saved.");
        }

        public void Update(Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "updated!");
        }
    }
}
