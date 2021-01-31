using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameManager
    {
        void Save(Game game,Gamers gamer);
        void Delete(Game game,Gamers gamers);
        void Update(Game game,Gamers gamers);
    }
}
