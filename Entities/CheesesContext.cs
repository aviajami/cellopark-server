using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cellopark_server.Entities
{
    public class CheesesContext: ICheeseContext
    {
        private CheesesMock m_cheesesMock = new CheesesMock();
        public IEnumerable<CheeseResponse> GetCheeses()
        {
            CheesesMock cheesesMock = new CheesesMock();
            List<Cheese> cheeses = cheesesMock.CreateCheesesMock();

            List<CheeseResponse> cheeseResponses = new List<CheeseResponse>();
            cheeses.ForEach(cheese => {
                cheese.UpdatePrice();
                cheeseResponses.Add(new CheeseResponse() { Name = cheese.Name, price = cheese.Price });
                });
            return cheeseResponses;
        }
    }
}
