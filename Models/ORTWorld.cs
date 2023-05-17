class ORTWorld
{
    public static List<string> ListaDestinos{get;private set;} = new List<string>{"MIAMI", "TORONTO", "MISIONES", "DUBAI", "BEIJING", "TOKIO", "BRASILIA", "MEDELLIN", "CARACAS", "SUCRE"};
    public static List<string> ListaHoteles{get;private set;} = new List<string>{"hotel1.jpg", "hotel2.jpg", "hotel3.jpg", "hotel4.jpg", "hotel5.jpg", "hotel6.jpg", "hotel7.jpg", "hotel8.jpg", "hotel.jpeg", "hotel10.jpg"};
    public static List<string> ListaAereo{get; private set;} = new List<string>{"emirates.png", "copa_air.jpg", "latam.png", "lufthansa.png", "air_china.png", "qatar.png", "aeromexico.jpeg", "aerolineas_argentinas.jpg", "british_airways.png", "american.png"};
    public static List<string> ListaExcursiones{get; private set;} = new List<string>{"boca.png", "mudomental.jpg", "independiente.png", "cilindro.jpg", "gasometro.jpg", "uno.jpg", "amalfitani.jpg", "bielsa.jpg", "arroyito.jpg", "maradona.jpg"};
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
