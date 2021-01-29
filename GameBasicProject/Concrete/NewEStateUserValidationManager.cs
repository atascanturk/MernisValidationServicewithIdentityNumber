using GameBasicProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameBasicProject.Concrete
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public async Task<bool>  ValidateIfReal(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var state = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.IdentityNumber), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.BirthYear));

            return state.Body.TCKimlikNoDogrulaResult;
        }

        bool IUserValidationService.Validate(Player player)
        {
            return ValidateIfReal(player).Result;
        }
    }
}
