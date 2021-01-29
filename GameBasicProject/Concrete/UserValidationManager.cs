using GameBasicProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasicProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear == 1994 && player.FirstName == "Cantürk" && player.LastName == "Ataş" && player.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
