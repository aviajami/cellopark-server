using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cellopark_server.Entities
{
    public class CheesesFactory
    {
        public Cheese CreateCheeses(Cheese cheese)
        {
            Cheese result;
            switch (cheese.Type)
            {
                case (Globals.CheeseType.Aged):
                {
                        result = new AgedCheese();
                        break;
                }
                case (Globals.CheeseType.Standard):
                    {
                        result = new StandradCheese();
                        break;
                    }
                case (Globals.CheeseType.Fresh):
                    {
                        result = new FreshCheese();
                        break;
                    }
                case (Globals.CheeseType.Unique):
                    {
                        result = new UniqueCheese();
                        break;
                    }
                case (Globals.CheeseType.Special):
                    {
                        result = new SpecialCheese();
                        break;
                    }
                default:
                    {
                        result = new StandradCheese();
                        break;
                    }
            }

            result.Name = cheese.Name;
            result.Price = cheese.Price;
            result.Type = cheese.Type;
            result.BestBeforeDate = cheese.BestBeforeDate;
            result.DaysToSell = cheese.DaysToSell;

            return result;
        }
    }
}
