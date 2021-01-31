using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesManager
    {
        void Buy(Gamers gamer, Game game, Campaign campaign);
    }
}
