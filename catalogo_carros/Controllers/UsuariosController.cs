using catalogo_carros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace catalogo_carros.Controllers
{
    
    public class UsuariosController : Controller
    {
        private readonly Contexto _contexto;

        public UsuariosController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Usuarios.ToListAsync());
        }
        [HttpGet]
        public IActionResult NovoUsuario()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> NovoUsuario(Usuario usuario)
        {
            await _contexto.Usuarios.AddAsync(usuario);
            await _contexto.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarUsuario(int usuarioId)
        {
            Usuario usuario = await _contexto.Usuarios.FindAsync(usuarioId);

            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarUsuario(Usuario usuario)
        {
            _contexto.Usuarios.Update(usuario);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> ExcluirUsuario(int usuarioId)
        {
            Usuario usuario = await _contexto.Usuarios.FindAsync(usuarioId);
            _contexto.Usuarios.Remove(usuario);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
