using GameBasicProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasicProject.Concrete
{
    interface ICampaignService
    {

        void CalculateDiscount(Game game);
        void CartInformation(Game game);


    }
}
