using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class1WebApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class1WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {

        private static IList<ICandidate> candidateList = new List<ICandidate>();
        // GET: api/Candidate
        [HttpGet]
        public IEnumerable<ICandidate> Get()
        {
            return candidateList;
        }

        // GET: api/Candidate/5
        [HttpGet("{id}", Name = "Get")]
        public ICandidate Get(int id)
        {
            return candidateList.Where(c => c.CandidateId == id).FirstOrDefault();
        }

        // POST: api/Candidate
        [HttpPost]
        public void Post([FromBody] Candidate candidate)
        {
            candidateList.Add(candidate);
        }

        // PUT: api/Candidate/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Candidate candidate)
        {
            var candidateByList = candidateList.Where(c => c.CandidateId == id).FirstOrDefault();
            candidateByList.FirstName = candidate.FirstName;
            //change it
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           var candidate= candidateList.Where(c => c.CandidateId == id).FirstOrDefault();
            candidateList.Remove(candidate);
        }
    }
}
