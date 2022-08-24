using APITeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {

        [HttpGet()]
        public IEnumerable<Categoria> Get()
        {

            return CategoriaLista.ToList();
        }


        public static List<Categoria> CategoriaLista = new List<Categoria>();


        [HttpPost()]
        public Categoria Post([FromBody] Categoria categoria)
        {

            CategoriaLista.Add(categoria);
            

            return categoria;
        }
    }
}