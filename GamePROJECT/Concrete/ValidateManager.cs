using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePROJECT.Abstract;
using GamePROJECT.Entities;

namespace GamePROJECT.Concrete
{
    public class ValidateManager:IValidateService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == 2000 && gamer.FirstName == "FATİH" && gamer.LastName == "SELVİ" && gamer.NationalityID == 222222)
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
