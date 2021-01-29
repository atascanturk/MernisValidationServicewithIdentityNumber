using GameBasicProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasicProject.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);


    }
}
