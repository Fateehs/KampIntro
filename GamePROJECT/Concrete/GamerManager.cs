using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePROJECT.Abstract;
using GamePROJECT.Entities;

namespace GamePROJECT.Concrete
{
    public class GamerManager : IGamerService
    {
        private IValidateService _validateService;

        public GamerManager(IValidateService validateService)
        {
            _validateService = validateService;
        }

        public void Register(Gamer gamer)
        {
            if (_validateService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " kayıt oldun tebrikler!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız kayıt başarısız!");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " bilgilerini başarıyla güncelledin!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " tüm kayıtların sistemden silindi!");
        }


    }
}
