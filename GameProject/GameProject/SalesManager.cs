using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesManager
    {
        public void Buy(Gamers gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " " + "adlı oyunu" + " " + campaign.CampaignName +" " + "almıştır.");
        }
    }
}
