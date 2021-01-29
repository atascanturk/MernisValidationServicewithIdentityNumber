using GameBasicProject.Abstract;
using GameBasicProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasicProject.Concrete
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;
        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated");
        }
    }
}
