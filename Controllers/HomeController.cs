using Microsoft.AspNetCore.Mvc;

namespace PaquetesTuristicos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes = ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        ViewBag.ListaAereo = ORTWorld.ListaAereo;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        return View();
    }
    public IActionResult GuardarPaquete(string Destino, string Hotel, string Aereo, string Excursion)
    {
        Paquete paquete = new Paquete(Hotel, Aereo, Excursion);
        ORTWorld.IngresarPaquete(Destino, paquete);
        return View();
    }
}
