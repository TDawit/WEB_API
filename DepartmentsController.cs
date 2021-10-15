using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : Controller
    {
        OrganizationDbContext organizationDbContext;
        
        public DepartmentsController(OrganizationDbContext _organizationDbContext)
        {
            organizationDbContext = _organizationDbContext;
        }

        [HttpGet]
        public IEnumerable<Departments> Get()
        {
            var depts = organizationDbContext.Departments.ToList();
            return depts;
        }
        [HttpGet("id")] // Get Api/controller/5
        public Departments Get(int id)
        {
            Departments D= organizationDbContext.Departments
                .Where(x=>x.Did == id).FirstOrDefault();
            return D;
        }
        [HttpPost] //to post 
        public Departments Post(Departments D)
        {
            organizationDbContext.Add<Departments>(D);
            organizationDbContext.SaveChanges();
            return D;
        }
          [HttpPut] // we are updating 
          public string Put(Departments D)
        {
            organizationDbContext.Update<Departments>(D);
            organizationDbContext.SaveChanges();
            return "Record updated";
        }
        [HttpDelete("{id}")] // this is to delte

        public string Delete(int id)
        {
            Departments D = organizationDbContext.Departments
                .Where(x => x.Did == id).FirstOrDefault();
            organizationDbContext.Remove<Departments>(D);
            organizationDbContext.SaveChanges();
            return "Record Deleted";
        }
        

    }
}
