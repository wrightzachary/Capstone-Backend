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
    public class GroupController : ControllerBase
    {

        private ApplicationDbContext _context;
        public GroupController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<GroupController>
        // GET ALL GROUPS
        [HttpGet]
        public IActionResult Get()
        {
            var groups = _context.Groups;
            return Ok(groups);
        }

        // GET api/<GroupController>/{id}
        // GET GROUP BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var group = _context.Groups.FirstOrDefault(group => group.GroupId == id);
            if (group == null)
            {
                return NotFound();
            }
            return Ok(group);
        }

        // POST api/<GroupController>
        // CREATE A GROUP
        [HttpPost]
        public IActionResult Post([FromBody] Group value)
        {
            _context.Groups.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<GroupController>/{id}
        // PUT GROUP
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Group value)
        {
            var group = _context.Groups.FirstOrDefault(group => group.GroupId == id);
            group.GroupName = value.GroupName;
            _context.SaveChanges();
            return Ok(group);
        }

        // DELETE api/<GroupController>/{id}
        // DELETE GROUP BY ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var group = _context.Groups.FirstOrDefault(group => group.GroupId == id);
            _context.Remove(group);
            _context.SaveChanges();
            return Ok();
        }
    }
}