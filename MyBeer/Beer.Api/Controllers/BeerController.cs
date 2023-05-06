using Beer.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Beer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : Controller
    {
        private readonly IMediator _mediator;
        public BeerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Beer.Core.Entities.Beer.Beer>> Get()
        {
            return await _mediator.Send(new GetAllBeer());
        }
        
    }
}
