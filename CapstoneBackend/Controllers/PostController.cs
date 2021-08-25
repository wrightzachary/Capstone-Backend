using CapstoneBackend.Data;
using CapstoneBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneBackend.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private ApplicationDbContext _context;
        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<PostController>
        // GET ALL POSTS
        [HttpGet]
        public IActionResult Get()
        {
            var posts = _context.Posts;
            return Ok(posts);
        }

        // GET api/<PostController>/{id}
        // GET POST BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var post = _context.Posts.FirstOrDefault(post => post.PostId == id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        // POST api/<PostControlelr>
        // CREATE A POST
        [HttpPost]
        public IActionResult Post([FromBody] Post value)
        {
            _context.Posts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<PostController>/{id}
        // PUT POST
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Post value)
        {
            var post = _context.Posts.FirstOrDefault(post => post.PostId == id);
            post.PostName = value.PostName;
            _context.SaveChanges();
            return Ok(post);
        }

        // DELETE api/<PostController>/{id}
        // DELETE POST BY ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var post = _context.Posts.FirstOrDefault(post => post.PostId == id);
            _context.Remove(post);
            _context.SaveChanges();
            return Ok();
        }
    }
}