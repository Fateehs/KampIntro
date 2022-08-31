using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePROJECT.Entities;

namespace GamePROJECT.Abstract
{
    public interface IValidateService
    {
        bool Validate(Gamer gamer);
    }
}
