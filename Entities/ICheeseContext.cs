using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cellopark_server.Entities
{
    public interface ICheeseContext
    {
        IEnumerable<CheeseResponse> GetCheeses();
    }
}
