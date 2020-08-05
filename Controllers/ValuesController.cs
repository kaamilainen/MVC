using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VisualStudioProject.Controllers
{
    [Route("api/oma")]
    [ApiController]
    public class ValuesController : Controller
    {
        [Route("luku")]
        public int Luku()
        {
            return 123;
        }
        [Route("merkkijono")]
        public string Merkkijono()
        {
            return "ABC";
        }

        [Route("merkkijonot")]
        public string[] Merkkijonot()
        {
            return new string[] { "ABCD", "DEFG" };
        }

        [Route("sattunnais")]
        public int Sattunnaisluku()
        {
            Random random = new Random();
            int luku = random.Next(1, 20);
            return luku;
        }
    }

}


/* GET: api/values
[HttpGet]
public IEnumerable<string> Get()
{
    return new string[] { "value1", "value2" };
}

// GET api/values/5
[HttpGet("{id}")]
public string Get(int id)
{
    return "value";
}

// POST api/values
[HttpPost]
public void Post([FromBody] string value)
{
}

// PUT api/values/5
[HttpPut("{id}")]
public void Put(int id, [FromBody] string value)
{
}

// DELETE api/values/5
[HttpDelete("{id}")]
public void Delete(int id)
{
}*/