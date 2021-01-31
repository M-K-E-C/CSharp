using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers gamer1 = new Gamers();
            gamer1.FirstName = "Musa kazım";
            gamer1.LastName = "Coşkun";
            gamer1.Id = 1;
            gamer1.NickName = "MKEC";
            gamer1.NationaltyId = "98745000";

            Gamers gamer2 = new Gamers();
            gamer2.FirstName = "Remzi";
            gamer2.LastName = "Coşkun";
            gamer2.Id = 2;
            gamer2.NickName = "Rmz";
            gamer2.NationaltyId = "98745432";

            Gamers gamer3 = new Gamers();
            gamer3.FirstName = "Elif";
            gamer3.LastName = "Coşkun";
            gamer3.Id = 3;
            gamer3.NickName = "ELF";
            gamer3.NationaltyId = "12345678";

            Game game1 = new Game { Id = 1, GameName = "CRYSİS", Gameprice = 140.5 };

            Game game2 = new Game();
            game2.GameName = "PUBG";
            game2.Gameprice = 87.5;
            game2.Id = 2;

            Game game3 = new Game();
            game3.Id = 3;
            game3.GameName = "SNİPER GHOST WARRİOR";
            game3.Gameprice = 114.45;


            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Kış Kampanyası";
            campaign1.GameId = 1;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Bahar Kampanyası";
            campaign2.GameId = 2;

            Campaign campaign3 = new Campaign();
            campaign3.CampaignName = "Sonbahar Kampanyası";
            campaign3.GameId = 3;

            IGamersManager gamerManager = new GamersManager();

            IGameManager gameManager = new GameManager();

            ISalesManager salesManager = new SalesManager();

            ICampaignManager campaignManager = new CampaignManager();

            gamerManager.Save(gamer1);

            gamerManager.Delete(gamer2);

            gamerManager.Update(gamer3);

            salesManager.Buy(gamer1, game1, campaign1);

            salesManager.Buy(gamer2, game3, campaign2);

            campaignManager.Add(campaign1);

            campaignManager.Update(campaign3);

            campaignManager.Delete(campaign2);
            Console.ReadLine();
        }
    }
}
