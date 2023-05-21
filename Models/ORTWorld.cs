class ORTWorld
{
    public static List<string> ListaDestinos{get;private set;} = new List<string>{"MIAMI", "TORONTO", "MISIONES", "DUBAI", "BEIJING", "TOKIO", "BRASILIA", "MEDELLIN", "CARACAS", "SUCRE"};
    public static List<string> ListaHoteles{get;private set;} = new List<string>{"~/img/hotel1.jpg", "~/img/hotel2.jpg", "~/img/hotel3.jpg", "~/img/hotel4.jpg", "~/img/hotel5.jpg", "~/img/hotel6.jpg", "~/img/hotel7.jpg", "~/img/hotel8.jpg", "~/img/hotel9.jpeg", "~/img/hotel10.jpg"};
    public static List<string> ListaAereo{get; private set;} = new List<string>{"~/img/emirates.png", "~/img/copa_air.jpg", "~/img/latam.png", "~/img/lufthansa.png", "~/img/air_china.png", "~/img/qatar.png", "~/img/aeromexico.jpeg", "~/img/aerolineas_argentinas.jpg", "~/img/british_airways.png", "~/img/american.png"};
    public static List<string> ListaExcursiones{get; private set;} = new List<string>{"~/img/boca.png", "~/img/mudomental.jpg", "~/img/independiente.png", "~/img/cilindro.jpg", "~/img/gasometro.jpg", "~/img/uno.jpg", "~/img/amalfitani.jpg", "~/img/bielsa.jpg", "~/img/arroyito.jpg", "~/img/maradona.jpg"};
    public static Dictionary<string, Paquete> Paquetes{get; private set;} = new Dictionary<string, Paquete>();
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool verificar;
        verificar = Paquetes.ContainsKey(destinoSeleccionado);
        if(verificar == false)
        {
            ListaDestinos.Add(destinoSeleccionado);
            Paquetes.Add(destinoSeleccionado, paquete);
        }
        return verificar;
    }
}
