using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cellopark_server.Entities
{
    public class SpecialCheese: Cheese
    {
        public override void UpdatePrice()
        {
            if (DaysToSell < 10 && DaysToSell > 5)
            {
                Price *= 0.95;
            } else if (DaysToSell <=5)
            {
                Price *= 0.90; 
            }
            CheckPriceRange();
        }
    }
}
