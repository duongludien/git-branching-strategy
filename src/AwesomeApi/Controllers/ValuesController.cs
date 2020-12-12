using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return new [] { 69, 97 };
        }
    }
}
