using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static cellopark_server.Entities.Globals;

namespace cellopark_server.Entities
{
    public class Cheese
    {
        public string Name { get; set; }
        public DateTime BestBeforeDate { get; set; }
        public int DaysToSell { get; set; }
        [Range(0, 20)]
        public double Price { get; set; }
        public CheeseType Type { get; set; }

        public virtual void UpdatePrice()
        {
            if (DateTime.Now <= BestBeforeDate)
            {
                Price *= 0.95;
            }
            else if (DaysToSell > 0)
            {
                Price *= 0.9;
            }
            else
            {
                Price = 0;
            }
            CheckPriceRange();
        }

        public void CheckPriceRange()
        {
            if (Price < 0)
            {
                Price = 0;
            }
            else if (Price > 20)
            {
                Price = 20;
            }
        }
    }
}
