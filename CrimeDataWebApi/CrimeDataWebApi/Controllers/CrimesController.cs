using CrimeDataWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;


namespace CrimeDataWebApi.Controllers
{
    public class CrimesController : ApiController
    {
        Crime[] crimes = new Crime[] 
        { 
            new Crime { id = 1, murderer = "Sam", victim = "Sandy", category = "knife", time = new DateTime(2014, 1, 18) }, 
            new Crime { id = 2, murderer = "Sally", victim = "James", category = "Gun", time = new DateTime(2011, 9, 20) }, 
            new Crime { id = 3, murderer = "Salu", victim = "Salu", category = "kill", time = new DateTime(2010, 5, 20) },
            new Crime { id = 4, murderer = "Sam", victim = "Sam", category = "knife", time = new DateTime(2014, 1, 18) }, 
            new Crime { id = 5, murderer = "Sally", victim = "Sally", category = "Gun", time = new DateTime(2011, 9, 20) }, 
            new Crime { id = 6, murderer = "Salu", victim = "Salu", category = "kill", time = new DateTime(2010, 5, 20) } 
        };

        public IEnumerable<Crime> GetAllCrimes()
        {
            return crimes;
        }

        public IHttpActionResult GetCrime(int id)
        {
            var crime = crimes.FirstOrDefault((c) => c.id == id);
            if (crime == null)
            {
                return NotFound();
            }
            return Ok(crime);
        }
    }
}