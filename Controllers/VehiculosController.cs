using Microsoft.AspNetCore.Mvc;
using RiveraMotors.Models;

namespace RiveraMotors.Controllers
{
    public class VehiculosController : Controller
    {
        public IActionResult Index()
        {
            var vehiculos = new List<Vehiculo>
            {
                new Vehiculo
                {
                    Nombre = "Toyota Corolla",
                    Tipo = "Sedán",
                    Año = 2026,
                    Motor = "2.0 L",
                    Precio = 95000000
                },

                new Vehiculo
                {
                    Nombre = "BMW Serie 3",
                    Tipo = "Sedán",
                    Año = 2025,
                    Motor = "2.0 L Turbo",
                    Precio = 180000000
                },

                new Vehiculo
                {
                    Nombre = "Mazda CX-5",
                    Tipo = "SUV",
                    Año = 2026,
                    Motor = "2.5 L",
                    Precio = 130000000
                }
            };

            return View(vehiculos);
        }

        [HttpPost]
        public IActionResult Registrar(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] =
                    $"Solicitud recibida para el vehículo {vehiculo.Nombre}.";
            }

            return RedirectToAction("Index");
        }
    }
}
