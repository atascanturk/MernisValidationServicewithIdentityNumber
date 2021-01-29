using GameBasicProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasicProject.Entities
{
    public class Campaign20Discount : ICampaignService
    {
        double newGamePrice;
        public void CalculateDiscount(Game game)
        {
            newGamePrice = game.GamePrice * 0.8;
        }

        public void CartInformation(Game game)
        {
            Console.WriteLine("Discount %30 is made to the game whose name is {0} and new price is {1} $", game.GameName, newGamePrice);
        }
    }
}
