using CapstoneBackend.Data;
using CapstoneBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Globalization;

namespace CapstoneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var users = _context.Users.ToList();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }
        // GET api/<UserController>/
        //[HttpGet("profile")]
        //public IActionResult GetUser([FromBody] User value)
        //{
        //    var userId = User.FindFirstValue("id");
        //    var user = _context.Users.Find(userId);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    var userInfo = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
        //    return Ok(userInfo);
        //}

        [HttpPost]
        public IActionResult Post([FromBody] User value)
        {

            _context.Users.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
