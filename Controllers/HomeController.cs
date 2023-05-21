using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class HomeController : Controller
{
    private static List<Paquete> paquetes = new List<Paquete>();

    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos = new List<string> { "MIAMI", "TORONTO", "MISIONES", "DUBAI", "BEIJING", "TOKIO", "BRASILIA", "MEDELLIN", "CARACAS", "SUCRE" };
        ViewBag.ListaHoteles = new List<string> { "~/img/hotel1.jpg", "~/img/hotel2.jpg", "~/img/hotel3.jpg", "~/img/hotel4.jpg", "~/img/hotel5.jpg", "~/img/hotel6.jpg", "~/img/hotel7.jpg", "~/img/hotel8.jpg", "~/img/hotel9.jpeg", "~/img/hotel10.jpg" };
        ViewBag.ListaAereo = new List<string> { "~/img/emirates.png", "~/img/copa_air.jpg", "~/img/latam.png", "~/img/lufthansa.png", "~/img/air_china.png", "~/img/qatar.png", "~/img/aeromexico.jpeg", "~/img/aerolineas_argentinas.jpg", "~/img/british_airways.png", "~/img/american.png" };
        ViewBag.ListaExcursiones = new List<string> { "~/img/boca.png", "~/img/mudomental.jpg", "~/img/independiente.png", "~/img/cilindro.jpg", "~/img/gasometro.jpg", "~/img/uno.jpg", "~/img/amalfitani.jpg", "~/img/bielsa.jpg", "~/img/arroyito.jpg", "~/img/maradona.jpg" };

        return View();
    }

    [HttpPost]
    public IActionResult GuardarPaquete(string Destino, int Hotel, int Aereo, int Excursion)
    {
        var paquete = new Paquete(Destino, Hotel.ToString(), Aereo.ToString(), Excursion.ToString());

        paquetes.Add(paquete);

        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        ViewBag.Paquetes = paquetes.ToDictionary(p => p.GetHashCode(), p => p);

        return View();
    }
}
