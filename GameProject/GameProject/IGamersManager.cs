using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamersManager
    {
        void Save(Gamers gamer);
        void Update(Gamers gamer);
        void Delete(Gamers gamer);

    }
}
