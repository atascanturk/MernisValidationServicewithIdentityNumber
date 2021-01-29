using GameBasicProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasicProject.Concrete
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
