using Atom.CultureShared;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atom.Culture.PublishServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public string Get()
        {
            return DateTime.Now.ToString();
        }

        // GET api/<ValuesController>/5
        [HttpGet("person/{id}")]
        public string GetPerson(string id)
        {
            // найти пользователя и выдать о нем информацию.
            Person person = new Person();
            person.Age = "19";
            person.Name = "Roman";
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(person);
            return result;
        }

        [HttpGet("group/{id}")]
        public string GetGroup(string ids)
        {
            // найти пользователя и выдать о нем информацию.
            Group group = new Group();
            group.Persons.Add(new Person() { Age = "11", Email="12121"});
            //person.Age = "19";
            //person.Name = "Roman";
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(group);
            return result;
        }            
    }
}
