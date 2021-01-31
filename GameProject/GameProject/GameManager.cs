using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameManager
    {
        public void Delete(Game game, Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " " + "deleted.");
        }

        public void Save(Game game, Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " " + "saved.");
        }

        public void Update(Game game, Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " " + "updated.");
        }
    }
}
