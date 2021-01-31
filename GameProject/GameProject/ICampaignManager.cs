using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
