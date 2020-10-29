using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace WebApiBoostrapper.Queries
{
    public class GetTemperaturesQuery: IRequest<IEnumerable<WeatherForecast>>
    {

    }
}
