using CapstoneBackend.Data;
using CapstoneBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var comments = _context.Comments;
            return Ok(comments);
        }

        // GET: api/<CommentController>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var comments = _context.Comments.Include(c => c.Post).Include(c => c.User).Where(comment => comment.PostId == id); 
            return Ok(comments);
        }


        // POST api/<CommentController>
        [HttpPost]
        public IActionResult Post([FromBody] Comment value)
        {
            _context.Comments.Add(value);
            var post = _context.Posts.FirstOrDefault(post => post.PostId == value.PostId);
            _context.SaveChanges();
            return Ok(value);
        }

        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Comment value)
        {
            var comment = _context.Comments.FirstOrDefault(comment => comment.CommentId == id);
            comment.CommentContext = value.CommentContext;
            comment.UserId = value.UserId;
            _context.SaveChanges();
            return Ok(comment);
        }

        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var comment = _context.Comments.FirstOrDefault(comment => comment.CommentId == id);
            _context.Remove(comment);
            _context.SaveChanges();
            return Ok();
        }
    }
}