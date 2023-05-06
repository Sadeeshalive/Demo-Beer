using Beer.Core.Entities.Beer;
using Beer.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer.Core.Repositories
{
    public interface IBeerRepository 
    {
        Task<IEnumerable<Entities.Beer.Beer>> GetBeerById(string id);
    }
}
