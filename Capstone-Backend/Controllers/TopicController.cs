using Capstone_Backend.Data;
using Capstone_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {

        private ApplicationDbContext _context;
        public TopicController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<TopicController>
        // GET ALL TOPICS
        [HttpGet]
        public IActionResult Get()
        {
            var topics = _context.Topics;
            return Ok(topics);
        }

        // GET api/<TopicController>/{id}
        // GET TOPIC BY ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var topic = _context.Topics.FirstOrDefault(topic => topic.TopicId == id); 
            if (topic == null)
            {
                return NotFound();
            }
            return Ok(topic);
        }

        // POST api/<TopicController>
        // CREATE A TOPIC
        [HttpPost]
        public IActionResult Post([FromBody] Topic value)
        {
            _context.Topics.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<TopicController>/{id}
        // PUT TOPIC
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Topic value)
        {
            var topic = _context.Topics.FirstOrDefault(topic => topic.TopicId == id);
            topic.TopicName = value.TopicName;
            _context.SaveChanges();
            return Ok(topic);
        }

        // DELETE api/<TopicController>/{id}
        // DELETE TOPIC BY ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var topic = _context.Topics.FirstOrDefault(topic => topic.TopicId == id);
            _context.Remove(topic);
            _context.SaveChanges();
            return Ok();
        }
    }
}
