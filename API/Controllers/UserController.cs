using Microsoft.AspNetCore.Mvc;

namespace API.Controllers{

    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase{

        [HttpGet]
        //GET /api/user/list
        [Route("list")]
        public IActionResult List(){

            return Ok("oi");
        }

    }
}