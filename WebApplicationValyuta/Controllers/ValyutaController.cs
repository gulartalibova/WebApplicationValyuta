using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationValyuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValyutaController : ControllerBase
    {
        AppDbContext dbContext = new AppDbContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = dbContext.Valyutas.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Valyuta v)
        {
            dbContext.Valyutas.Add(v);
            dbContext.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult Update (Valyuta v) 

        {
            dbContext.Valyutas.Update(v);
            dbContext.SaveChanges();
            return Ok();
        } 

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
           var Valyus=dbContext.Valyutas.Find(id);
            dbContext.Valyutas.Remove(Valyus);
            dbContext.SaveChanges();
            return Ok();

        }
    }
}
