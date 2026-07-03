using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    [EnableCors(PolicyName="fispl")]
    [Route("api/[controller]")]   // /api/Values
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmpDbContext _dbContext;
        public ValuesController(EmpDbContext context)
        {
            _dbContext = context;


        }

        [HttpGet]
        public List<Emp> GetAllEmps()
        {
            var emps = _dbContext.Emps.ToList();
            return emps;

        }
        [HttpPost]   //POST: /api/values

        public void Post(Emp emp)
        {
            _dbContext.Emps.Add(emp);
            _dbContext.SaveChanges();
        }

        [HttpPut("{id}")]   //Put: /api/values/id

        public void Put(int id , Emp emp)
        {
            Emp e = _dbContext.Emps.Find(id);
            e.Name = emp.Name;
            e.Name = emp.Address;

            _dbContext.SaveChanges();
        }

        [HttpDelete ("{id}")]

        public void Delete(int id)
        {
            Emp e = _dbContext.Emps.Find(id);
            _dbContext.Emps.Remove(e);
            _dbContext.SaveChanges();
        }


        // only one get ok 
        //[HttpGet]

        //public string GetName()
        //{
        //    return "Prabhanshu LAkshakar";
        ////}

        //[HttpGet]

        //public string[] GetNames()
        //{
        //    return new string[] { "Praful","mukund","gopal","prabhasnhu"}
        //    ;
        //}


    }
}
