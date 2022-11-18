using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSAuto.Contexto;
using WSAuto.Models;


namespace WSAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public AutoController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            //LinqtoEntities Todos los Autores

            return context.Autos.ToList();
        }
        [HttpGet("{id}")]

        public ActionResult<Auto> Get(int id)
        {
            var resultado = context.Autos.FirstOrDefault(x => x.AutoId == id);
            if (resultado == null) { return NotFound(); }

            return resultado;
        }

        [HttpGet("modelo/{modelo}")]
        public ActionResult<Auto> Get(string modelo)
        {
            var resultado = context.Autos.FirstOrDefault(x => x.Modelo == modelo);
            if (resultado == null) { return NotFound(); }

            return resultado;
        }


      

        [HttpGet("marca/{marca}")]
        public ActionResult<Auto> GetXMarca(string marca)
        {
            var resultado = context.Autos.FirstOrDefault(x => x.Marca == marca);
            if (resultado == null) { return NotFound(); }

            return resultado;
        }

       




        [HttpGet("{marca}/{modelo}")]
        public ActionResult<Auto> Get(string marca,  string modelo)
        {
            var resultado = context.Autos.FirstOrDefault(x => x.Modelo == modelo && x.Marca == marca);
            if (resultado == null) { return NotFound(); }

            return resultado;
        }

        [HttpPost]

        public ActionResult Post([FromBody] Auto auto)
        {
            context.Autos.Add(auto);
            context.SaveChanges();
            /*return new CreatedAtRouteResult("ObtenerAutor",
                                              new { id = autor.AutorId },
                                              autor);*/

            return Ok();

        }
        [HttpPut("{id}")]

        public ActionResult Put(int id, [FromBody] Auto auto)
        {
            if (id != auto.AutoId)
            {
                BadRequest();
            }
            context.Entry(auto).State = EntityState.Modified;

            context.SaveChanges();
            return NoContent();


        }
        [HttpDelete("{id}")]

        public ActionResult<Auto> Delete(int id)
        {
            var resultado = context.Autos.FirstOrDefault(x => x.AutoId == id);

            if (resultado == null)
            {
                return NotFound();
            }
            context.Autos.Remove(resultado);
            context.SaveChanges();
            return resultado;

        }




    }


}

