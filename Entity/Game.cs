using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get
            {
                return Price;

            } set
            {
                Price = Price - Price * Discount / 100;
            } 
        }
        public int Discount {  get; set; }
    }

}
