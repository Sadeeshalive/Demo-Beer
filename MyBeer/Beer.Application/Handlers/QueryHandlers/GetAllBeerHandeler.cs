using Beer.Application.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beer.Core;
using Beer.Core.Repositories;

namespace Beer.Application.Handlers.QueryHandlers
{
    public class GetAllBeerHandeler: IRequestHandler<GetAllBeer,List<Beer.Core.Entities.Beer.Beer>>
    {
        private readonly IBeerRepository _beerRepository;
        public GetAllBeerHandeler(IBeerRepository beerRepository)
        {
            _beerRepository= beerRepository;
        }
        public async Task<List<Core.Entities.Beer.Beer>> Handle(GetAllBeer request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Beer.Beer>)await _beerRepository.GetBeerById("");
        }

    }
}
