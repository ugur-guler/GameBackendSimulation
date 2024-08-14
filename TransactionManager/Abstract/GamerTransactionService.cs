using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManager.Abstract
{
     interface GamerTransactionService
    {
        void AddGamer(Gamer gamer);
        void RemoveGamer(Gamer gamer);
        void UpdateGamer(int id, Gamer gamer);
    }
}
