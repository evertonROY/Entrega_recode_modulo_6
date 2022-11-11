using GrandLine.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrandLine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly AgenciaDbContext _context;

        public UsuarioController(AgenciaDbContext context)
        {
            _context = context;
        }

        //POST: CRIA UM NOVO USUARIO
        [HttpPost]
        public IActionResult CriarUsuario(Usuario item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Passageiro.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // GET: api/Usuario - LISTA TODOS OS Passageiros 
        [HttpGet]
        public IEnumerable<Usuario> GetPassageiro()
        {
            return _context.Passageiro;
        }

        // GET: api/Usuario/id - LISTA USUARIO POR ID
        [HttpGet("{id}")]
        public IActionResult GetUsuarioPorId(int id)
        {
            Usuario item = _context.Passageiro.SingleOrDefault(modelo => modelo.UsuarioId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        //PUT: ATUALIZA UM USUARIO EXISTENTE
        [HttpPut("{id}")]
        public IActionResult AtualizaUsuario(int id, Usuario item)
        {
            if (id != item.UsuarioId)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        //DELETE: DELETAR UM USUARIO POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaUsuario(int id)
        {
            var item = _context.Passageiro.SingleOrDefault(modelo => modelo.UsuarioId == id);

            if (item == null)
            {
                return BadRequest();
            }

            _context.Passageiro.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }
    }
}
