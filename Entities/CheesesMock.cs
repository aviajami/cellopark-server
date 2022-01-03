using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cellopark_server.Entities
{
    public class CheesesMock
    {
        List<Cheese> cheeses = new List<Cheese>();

        public List<Cheese> CreateCheesesMock()
        {
            Cheese c = new Cheese()
            {
                Name = "Roquefort",
                Price = 12.35,
                BestBeforeDate = new DateTime(2022, 01, 12),
                DaysToSell = 20,
                Type = Globals.CheeseType.Standard
            };
            cheeses.Add(c);
          
            c = new Cheese()
            {
                Name = "Calcagno",
                Price = 15.21,
                BestBeforeDate = new DateTime(2022, 02, 1),
                DaysToSell = 30,
                Type = Globals.CheeseType.Unique
            };
            cheeses.Add(c);
            c = new Cheese()
            {
                Name = "Queso Fresco",
                Price = 5.4,
                BestBeforeDate = new DateTime(2022, 01, 10),
                DaysToSell = 10,
                Type = Globals.CheeseType.Fresh
            };
            cheeses.Add(c);
            c = new Cheese()
            {
                Name = "Dragon Mozzarella",
                Price = 4.1,
                BestBeforeDate = new DateTime(2022, 01, 17),
                DaysToSell = 30,
                Type = Globals.CheeseType.Special
            };
            cheeses.Add(c);
            c = new Cheese()
            {
                Name = "Adam",
                Price = 12.35,
                BestBeforeDate = new DateTime(2022, 01, 29),
                DaysToSell = 30,
                Type = Globals.CheeseType.Standard
            };
            cheeses.Add(c);
            return cheeses;
        }

    }
}
