using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Apple", "Banana", "Orange" });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Value : {id}");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("Record Inserted Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok("Record Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Record Deleted Successfully");
        }
    }
}