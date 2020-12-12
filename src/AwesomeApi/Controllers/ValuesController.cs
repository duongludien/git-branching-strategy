using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }
    }
}
