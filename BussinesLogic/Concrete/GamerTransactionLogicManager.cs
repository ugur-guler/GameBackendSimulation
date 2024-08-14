using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class GamerTransactionLogicManager : GamerTransactionLogicService
    {
        public bool AddGamerToSystem(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " is real person");
            return true;
        }
    }
}
