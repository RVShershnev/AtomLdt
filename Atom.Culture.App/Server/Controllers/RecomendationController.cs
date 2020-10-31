using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Shared;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atom.Culture.App.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecomendationController : Controller
    {
     
        //public RecomendationController()
        //{
        
        //}

        //[HttpGet("{id}")]
        //public Person Get(int id)
        //{
        //    var result = new Person();
        //    result.Recomendations = new List<IRecomendation>();
        //    return result;
        //}

        //// POST api/recomendation/rec
        //[HttpPost]
        //public bool SendPerson(int id, [FromBody] Group value)
        //{
        //    return true;
        //}

        //// POST api/recomendation/rec
        //[HttpPost]
        //public bool SendPerson([FromBody] Person value)
        //{
        //    return true;
        //}
    }
}
