using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManager.Abstract
{
     interface InGameTransactionService
    {
        List<Game> ListGames();
        void SellingGame(Gamer gamer , Game game);

    }
}
