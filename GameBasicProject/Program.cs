using GameBasicProject.Concrete;
using System;

namespace GameBasicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager( new NewEStateUserValidationManager());
            playerManager.Add(new Entities.Player { Id = 1, BirthYear = 1994, FirstName = "Cantürk", LastName = "Ataş", IdentityNumber = 12345 }); //12345 yerine TC No girilmeli.
        }
    }
}
