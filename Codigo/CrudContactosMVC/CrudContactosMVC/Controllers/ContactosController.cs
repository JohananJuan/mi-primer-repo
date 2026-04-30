using CrudContactosMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CrudContactosMVC.Controllers
{
    public class ContactosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactosController(ApplicationDbContext context)
        {
                _context = context;
        }

        // GET: Contactos

        public async Task <IActionResult> Index()
        {
            var contactos = await _context.Contactos.ToListAsync();
            return View(contactos);
        }
    }
}
