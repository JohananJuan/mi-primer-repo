using CrudContactosMVC.Data;
using CrudContactosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudContactosMVC.Controllers
{
    public class ContactosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contactos = await _context.Contactos.ToListAsync();
            return View(contactos);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Contacto contacto)
        {
            // VERIFICACIÓN 1: ¿Llegan los datos?
            System.Diagnostics.Debug.WriteLine("=== INICIO DEL POST CREAR ===");
            System.Diagnostics.Debug.WriteLine($"Nombre recibido: '{contacto.Nombre}'");
            System.Diagnostics.Debug.WriteLine($"Correo recibido: '{contacto.Correo}'");
            System.Diagnostics.Debug.WriteLine($"Teléfono recibido: '{contacto.Telefono}'");
            System.Diagnostics.Debug.WriteLine($"Dirección recibida: '{contacto.Direccion}'");

            // VERIFICACIÓN 2: ¿El modelo es válido?
            if (!ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: ModelState NO es válido");
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error de validación: {error.ErrorMessage}");
                        // Guardar mensaje para mostrar en vista
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
                return View(contacto);
            }

            System.Diagnostics.Debug.WriteLine("ModelState es válido, intentando guardar...");

            try
            {
                // VERIFICACIÓN 3: Intentar guardar
                _context.Add(contacto);
                System.Diagnostics.Debug.WriteLine("Contacto añadido al contexto");

                int result = await _context.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"SaveChangesAsync completado. Registros afectados: {result}");

                if (result > 0)
                {
                    TempData["Success"] = "¡Contacto guardado exitosamente!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Error"] = "No se guardó ningún registro";
                    return View(contacto);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"EXCEPCIÓN: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                TempData["Error"] = $"Error al guardar: {ex.Message}";
                return View(contacto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = await _context.Contactos.FindAsync(id);

            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, Contacto contacto)
        {
            if (id != contacto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contacto);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }

                catch (DbUpdateConcurrencyException)
                {
                    if(!ContactoExist(contacto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }
            }
            return View(contacto);

        }


        [HttpGet]
        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = await _context.Contactos.FirstOrDefaultAsync (m => m.Id == id);

            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }


        [HttpGet]
        public async Task<IActionResult> Borrar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = await _context.Contactos.FirstOrDefaultAsync(m => m.Id == id);

            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrar(int id)
        {
            var contacto = await _context.Contactos.FindAsync(id);
            if (contacto != null)
            {
                _context.Contactos.Remove(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }



        private bool ContactoExist(int id)
        {
            return _context.Contactos.Any((e => e.Id == id));
        }


    }
}