using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace API.Controllers{

    [ApiController] // Note Informing type of Controller
    [Route("api/user")] // Note about route
    public class UserController : ControllerBase{

        private static List<User> users = new List<User>();

        [HttpGet]
        //GET at route /api/user/list
        [Route("list")]
        public IActionResult List(){
            return Ok(users);
        }

        //POST at /api/user/register
         
        [HttpPost]
        [Route("register")] 

        public IActionResult Register( [FromBody] User user){
        
        users.Add(user);
        
            return Created("", users);
        }

        //
        [HttpGet]
        [Route("list/{login}")]

        public IActionResult Search([FromRoute] string login){

         for(int i=0; i< users.Count; i++){
                if(users[i].Login == login){
                    return Ok(users[i]);
                }
            }
        // List<Usersearched = users.Find(login);
            // return Ok(searched);
            return NotFound();
        }
    }
}