using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiBoostrapper.Queries;
using WebApiBoostrapper.Services;

namespace WebApiBoostrapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IMediator _mediator;
        private  readonly INotifierMediatorService _notifierMediatorService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator, INotifierMediatorService notifierMediatorService)
        {
            _logger = logger;
            _mediator = mediator;
            _notifierMediatorService = notifierMediatorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var query = new GetTemperaturesQuery();
            var result = await _mediator.Send(query);

            _notifierMediatorService.Notify("Calling Gettemperature Endpoint. ");
            return Ok(result);

          
        }
    }
}
