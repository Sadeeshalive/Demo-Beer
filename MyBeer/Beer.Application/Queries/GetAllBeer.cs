using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Beer.Application.Queries
{
    public class GetAllBeer: IRequest<List<Beer.Core.Entities.Beer.Beer>>
    {
    }
}
