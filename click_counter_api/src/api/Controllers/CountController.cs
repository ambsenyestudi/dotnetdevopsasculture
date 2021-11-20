using ClickCounter.Application;
using ClickCounter.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace ClickCounter.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountController : ControllerBase
    {
        private readonly ICountService service;
        private readonly ILogger<CountController> logger;

        public CountController(ICountService service, ILogger<CountController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<Count> Get(CancellationToken cancellationToken) =>
            await service.GetCountAsync(cancellationToken).ConfigureAwait(false);
        
        [HttpPut]
        public async Task<Count> Increment(CancellationToken cancellationToken) 
        {
            await service.IncrementClickCountAsync(cancellationToken).ConfigureAwait(false);
            return await service.GetCountAsync(cancellationToken).ConfigureAwait(false);
        }
    }

}
